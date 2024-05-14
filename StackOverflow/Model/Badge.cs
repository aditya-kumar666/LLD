namespace StackOverflow.Model
{
    public class Badge
    {
        string name;

        public Badge(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Badge{" +
                    "name='" + name + '\'' +
                    '}';
        }
    }
}
