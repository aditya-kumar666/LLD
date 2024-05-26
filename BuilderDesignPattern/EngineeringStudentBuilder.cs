namespace BuilderDesignPattern
{
    public class EngineeringStudentBuilder : StudentBuilder
    {
        public override StudentBuilder setSubjects()
        {
            List<string> subjects = ["DSA", "OS", "CA"];
            return addSubjects(subjects);
        }
    }
}
