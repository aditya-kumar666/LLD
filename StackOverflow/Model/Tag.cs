namespace StackOverflow.Model
{
    public class Tag
    {
        string tagId;
        string tag;

        public Tag(string tag) {
            tagId = new Guid().ToString();
            this.tag = tag;
        }

        public override string ToString()
        {
            return "Tag{" +
                    "tagId='" + tagId + '\'' +
                    ", tag='" + tag + '\'' +
                    '}';
        }
    }
}
