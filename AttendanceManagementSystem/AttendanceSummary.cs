using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem
{
    internal class AttendanceSummary
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int TotalClasses { get; set; }
        public int AttendedClasses { get; set; }

        public double GetPercentage()
        {
            if (TotalClasses == 0) return 0;
            return (AttendedClasses * 100) / TotalClasses;
        }
    }
}
