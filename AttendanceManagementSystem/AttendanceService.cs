using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class AttendanceService
    {
        List<AttendanceRecord> records = new();
        Dictionary<(int studentId, int subjectId), AttendanceSummary> summaryMap = new();

        public void MarkAttendance(int studentId, int subjectId, bool isPresent)
        {
            records.Add(new AttendanceRecord
            {
                StudentId = studentId,
                SubjectId = subjectId,
                Date = DateTime.Now,
                IsPresent = isPresent
            });

            var key = (studentId, subjectId);
            if (!summaryMap.ContainsKey(key))
            {
                summaryMap[key] = new AttendanceSummary
                {
                    StudentId = studentId,
                    SubjectId = subjectId,
                    TotalClasses = 0,
                    AttendedClasses = 0
                };
            }

            summaryMap[key].TotalClasses++;
            if (isPresent)
            {
                summaryMap[key].AttendedClasses++;
            }
        }

        public List<Student> GetDefaulters(List<Student> students, List<Subject> sub)
        {
            var defaulters = new List<Student>();
            foreach (var student in students)
            {
                foreach (var subject in sub)
                {
                    var key = (student.Id, subject.Id);
                    if (!summaryMap.ContainsKey(key))
                    {
                        defaulters.Add(student);
                        break;
                    }

                    if (summaryMap.ContainsKey(key))
                    {
                        var summary = summaryMap[key];
                        double attendancePercentage = summary.GetPercentage();
                        if (attendancePercentage < subject.MinAttendancePercentage)
                        {
                            defaulters.Add(student);
                            break; // No need to check other subjects for this student
                        }
                    }
                }
            }
            return defaulters;
        }
    }
}
