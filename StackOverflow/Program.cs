using StackOverflow;
using StackOverflow.Model;

public class Program
{
    public static void Main(string[] args)
    {
        StackOverflowDao stackOverflowDao = new StackOverflowDao();
        Guest guest = new Guest();
        Account account = new Account("Aditya", "aditya@gmail.com");
        Member member = new Member(account);

        Account account2 = new Account("Aditya2", "aditya2@gmail.com");
        Member member2 = new Member(account2);

        Question question = new Question("Technical question", member);
        member.addQuestion(stackOverflowDao, question);
        getAllQuestions(guest, stackOverflowDao);

        Comment comment = new Comment("Comment on question", member2);
        member2.addCommentToQuestion(stackOverflowDao, question.getEntityId(), comment);
        getAllQuestions(guest, stackOverflowDao);

        Answer answer = new Answer("Answer", member2);
        member2.addAnswer(stackOverflowDao, question.getEntityId(), answer);
        getAllQuestions(guest, stackOverflowDao);

        Comment comment1 = new Comment("Comment on answer", member2);
        member2.addCommentToAnswer(stackOverflowDao, answer.getEntityId(), comment1);
        getAllQuestions(guest, stackOverflowDao);
    }

    static void getAllQuestions(Guest guest, StackOverflowDao st)
    {
        Console.WriteLine(guest.searchQuestions(st));
    }
}