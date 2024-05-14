namespace StackOverflow.Model
{
    public class Member : Guest
    {
        Account account;
        List<Badge> badgeList;
        public Member(Account acc)
        {
              account = acc;
            badgeList = new List<Badge>();
        }

        public void addBadge(Badge badge)
        {
            this.badgeList.Add(badge);
        }

        public List<Badge> getBadgeList()
        {
            return badgeList;
        }


        public void addQuestion(StackOverflowDao stackOverflowDao, Question question)
        {
            stackOverflowDao.addQuestion(question);
        }

        public void addAnswer(StackOverflowDao stackOverflowDao, String questionId, Answer answer)
        {
            stackOverflowDao.addAnswer(questionId, answer);
        }

        public void addCommentToQuestion(StackOverflowDao stackOverflowDao, String questionId, Comment comment)
        {
            stackOverflowDao.addCommentToQuestion(questionId, comment);
        }

        public void addCommentToAnswer(StackOverflowDao stackOverflowDao, String answerId, Comment comment)
        {
            stackOverflowDao.addCommentToAnswer(answerId, comment);
        }

        public void addTagToQuestion(StackOverflowDao stackOverflowDao, String questionId, Tag tag)
        {
            stackOverflowDao.addTagToQuestion(questionId, tag);
        }

        
        public override string ToString()
        {
            return "Member{" +
                    "account=" + account +
                    ", badgeList=" + badgeList +
                    '}';
        }
    }
}
