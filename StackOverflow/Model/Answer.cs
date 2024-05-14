namespace StackOverflow.Model
{
    public class Answer : Entity
    {
        List<Comment> comments;

        public Answer(string content, Member owner) : base(content, owner)
        {
            comments = new List<Comment>();
        }

        public List<Comment> getComments()
        {
            return comments;
        }

        public void addComment(Comment comment)
        {
            this.comments.Add(comment);
        }

        
        public override string ToString()
        {
            return "Answer{" +
                    ", Content= " + getContent() +
                    ", comments=" + comments +
                    ", owner=" + getOwner() +
                    '}';
        }
    }
}
