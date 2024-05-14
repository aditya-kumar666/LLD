using System.Xml.Linq;

namespace StackOverflow.Model
{
    public class Question : Entity
    {
        List<Answer> answers;
        List<Comment> comments;
        int bounty;
        List<Tag> tags;
        bool isOpen;

        public Question(string content, Member member) : base(content, member)
        {
            answers = new List<Answer>();
            comments = new List<Comment>();
            tags = new List<Tag>();
            isOpen = true;
            bounty = 0;
        }


        public int getBounty()
        {
            return bounty;
        }

        public void setBounty(int bounty)
        {
            this.bounty = bounty;
        }

        public Boolean getOpen()
        {
            return isOpen;
        }

        public void setOpen(Boolean open)
        {
            isOpen = open;
        }

        public List<Answer> getAnswers()
        {
            return answers;
        }

        public List<Comment> getComments()
        {
            return comments;
        }

        public List<Tag> getTags()
        {
            return tags;
        }

        public void addAnswer(Answer answer)
        {
            this.answers.Add(answer);
        }

        public void addTag(Tag tag)
        {
            this.tags.Add(tag);
        }

        public void addComment(Comment comment)
        {
            this.comments.Add(comment);
        }

        public override string ToString()
        {
            return "Question{" +
                "Content= " + base.getContent() +
                ", answers=" + answers +
                ", comments=" + comments +
                ", bounty=" + bounty +
                ", tags=" + tags +
                ", isOpen=" + isOpen +
                ", owner=" + base.getOwner() +
                '}';
        }
    }
}
