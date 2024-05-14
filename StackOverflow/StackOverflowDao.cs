using StackOverflow.Model;

namespace StackOverflow
{
    public class StackOverflowDao
    {
        Dictionary<string, Question> questionIdToQuestionMap;
        Dictionary<string, Answer> answerIdToAnswerMap;
        Dictionary<string, Comment> commentIdToCommentMap;

        public StackOverflowDao()
        {
            questionIdToQuestionMap = new Dictionary<string, Question>();
            answerIdToAnswerMap = new Dictionary<string, Answer>();
            commentIdToCommentMap = new Dictionary<string, Comment>();
        }

        public List<Question> getAllQuestions()
        {
            return questionIdToQuestionMap.Select(x => x.Value).ToList();
        }

        public Question getQuestion(String questionId)
        {
            return this.questionIdToQuestionMap[questionId];
        }

        public void addQuestion(Question question)
        {
            this.questionIdToQuestionMap.Add(question.getEntityId(), question);
        }

        public void addAnswer(string questionId, Answer answer)
        {
            Question question = questionIdToQuestionMap[questionId];
            if (question != null)
            {
                question.addAnswer(answer);
            }
            answerIdToAnswerMap.Add(answer.getEntityId(), answer);
        }

        public void addCommentToQuestion(String questionId, Comment comment)
        {
            Question question = questionIdToQuestionMap[questionId];
            if (question != null)
            {
                question.addComment(comment);
            }
            commentIdToCommentMap.Add(comment.getEntityId(), comment);
        }

        public void addCommentToAnswer(string answerId, Comment comment)
        {
            Answer answer = answerIdToAnswerMap[answerId];
            if (answer != null)
            {
                answer.addComment(comment);
            }
            commentIdToCommentMap.Add(comment.getEntityId(), comment);
        }

        public void addTagToQuestion(string questionId, Tag tag)
        {
            getQuestion(questionId).addTag(tag);
        }

    }
}
