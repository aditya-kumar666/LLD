namespace StackOverflow.Model
{
    public class Guest
    {
        public List<Question> searchQuestions(StackOverflowDao stackOverflowDao)
        {
            return stackOverflowDao.getAllQuestions();
        }

        public Question getQuestion(StackOverflowDao stackOverflowDao, string questionId)
        {
            return stackOverflowDao.getQuestion(questionId);
        }
    }
}
