namespace BuilderDesignPattern
{
    public class Student
    {
        int rollNumber;
        int age;
        String name;
        String fatherName;
        String motherName;
        List<String> subjects;

        public Student(StudentBuilder builder)
        {
            this.rollNumber = builder.getRollNumber();
            this.age = builder.getAge();
            this.name = builder.getName();
            this.fatherName = builder.getFatherName();
            this.motherName = builder.getmotherName();
            this.subjects = builder.getSubjects();
        }

        public String toString()
        {
            return "" + " roll number: " + this.rollNumber +
                    " age: " + this.age +
                    " name: " + this.name +
                    " father name: " + this.fatherName +
                    " mother name: " + this.motherName +
                    " subjects: " + subjects[0] + "," + subjects[1] + "," + subjects[2];
        }

    }
}
