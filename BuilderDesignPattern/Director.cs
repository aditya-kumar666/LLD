﻿namespace BuilderDesignPattern
{
    public class Director
    {
        StudentBuilder studentBuilder;

        public Director(StudentBuilder studentBuilder)
        {
            this.studentBuilder = studentBuilder;
        }

        public Student createStudent()
        {
            if(studentBuilder is EngineeringStudentBuilder)
            {
                return createEngineeringStudent();
            }
            else if(studentBuilder is MBAStudentBuilder)
            {
                return createMbaStudent();
            }
            return null;
        }

        Student createEngineeringStudent()
        {
            return studentBuilder.setName("Aditya").setRollNumber(1).setAge(22).setSubjects().build();
        }

        Student createMbaStudent()
        {
            return studentBuilder.setName("Saumya").setRollNumber(2).setAge(23).setSubjects().build();
        }
    }
}
