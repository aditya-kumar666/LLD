namespace BuilderDesignPattern
{
    public class MBAStudentBuilder : StudentBuilder
    {
        public override StudentBuilder setSubjects()
        {
            List<string> subs = ["Micro Economics", "Business Studies", "Operations Management"];
            return addSubjects(subs);
        }
    }
}
