namespace BuilderDesignPattern
{
    public abstract class StudentBuilder
    {
        int rollNo;
        int age;
        string name;
        string fatherName;
        string motherName;
        List<string> subjects;

        public StudentBuilder setRollNumber(int rollNo)
        {
            this.rollNo = rollNo;
            return this;
        }

        public StudentBuilder setAge(int age)
        {
            this.age = age;
            return this;
        }

        public int getRollNumber()
        {
            return this.rollNo;
        }

        public int getAge()
        {
            return this.age;
        }

        public string getName()
        {
            return this.name;
        }

        public string getFatherName()
        {
            return this.fatherName;
        }

        public string getmotherName() {
            return this.motherName;
        }

        public List<string> getSubjects()
        {
            return this.subjects;
        }

        public StudentBuilder setName(String name)
        {
            this.name = name;
            return this;
        }

        public StudentBuilder setFatherName(String fatherName)
        {
            this.fatherName = fatherName;
            return this;
        }

        public StudentBuilder setMotherName(String motherName)
        {
            this.motherName = motherName;
            return this;
        }

        public StudentBuilder addSubjects(List<string> sub)
        {
            this.subjects = sub;
            return this;
        }

        public abstract StudentBuilder setSubjects();

        public Student build()
        {
            return new Student(this);
        }
    }
}
