using BuilderDesignPattern;

public class Client
{
    public static void Main(string[] args)
    {
        Director obj1 = new Director(new EngineeringStudentBuilder());
        Director obj2 = new Director(new MBAStudentBuilder());


        //Student engineerStudent = obj1.createStudent();
        //Student mbaStudent = obj2.createStudent();
        Student engineerStudent = obj1.createStudent("Aditya", 1, 22);
        Student mbaStudent = obj2.createStudent("saumya", 2, 23);

        Console.WriteLine(engineerStudent.toString());
        Console.WriteLine(mbaStudent.toString());
    }
}