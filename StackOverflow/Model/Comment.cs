namespace StackOverflow.Model
{
    public class Comment : Entity
    {
        public Comment(string content, Member owner) : base(content, owner)
        {
            
        }

        public override string ToString()
        {
            return "Comment{ " +
                    " Content= " + getContent() +
                    " Owner= " + getOwner() +
                    "}";
        }
    }
}
