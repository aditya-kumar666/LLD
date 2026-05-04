using AttendanceManagementSystem;

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Aditya" },
            new Student { Id = 2, Name = "Rahul" }
        };

        var subjects = new List<Subject>
        {
            new Subject { Id = 1, Name = "Math", MinAttendancePercentage = 75 },
            new Subject { Id = 2, Name = "Physics", MinAttendancePercentage = 70 }
        };

        var service = new AttendanceService();

        // Sample attendance
        service.MarkAttendance(1, 1, true);
        service.MarkAttendance(1, 1, false);
        service.MarkAttendance(1, 2, true);

        service.MarkAttendance(2, 1, false);
        service.MarkAttendance(2, 1, false);

        var defaulters = service.GetDefaulters(students, subjects);

        Console.WriteLine("Defaulters:");
        foreach (var s in defaulters)
        {
            Console.WriteLine(s.Name);
        }
    }
}