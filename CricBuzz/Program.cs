using CricBuzz.Team;
using CricBuzz;
using CricBuzz.Team.Player;

public class Program
{
    public static void Main(string[] args)
    {
        Program ob = new Program();

        Team teamA = ob.addTeam("India");
        Team teamB = ob.addTeam("SriLanka");

        IMatchType matchType = new T20MatchType();
        Match match = new Match(teamA, teamB, null, "SMS STADIUM", matchType);
        match.startMatch();

    }


    private Team addTeam(String name)
    {

        Queue<PlayerDetails> playerDetails = new ();

        PlayerDetails p1 = addPlayer(name + "1", PlayerType.Allrounder);
        PlayerDetails p2 = addPlayer(name + "2", PlayerType.Allrounder);
        PlayerDetails p3 = addPlayer(name + "3", PlayerType.Allrounder);
        PlayerDetails p4 = addPlayer(name + "4", PlayerType.Allrounder);
        PlayerDetails p5 = addPlayer(name + "5", PlayerType.Allrounder);
        PlayerDetails p6 = addPlayer(name + "6", PlayerType.Allrounder);
        PlayerDetails p7 = addPlayer(name + "7", PlayerType.Allrounder);
        PlayerDetails p8 = addPlayer(name + "8", PlayerType.Allrounder);
        PlayerDetails p9 = addPlayer(name + "9", PlayerType.Allrounder);
        PlayerDetails p10 = addPlayer(name + "10", PlayerType.Allrounder);
        PlayerDetails p11 = addPlayer(name + "11", PlayerType.Allrounder);

        playerDetails.Enqueue(p1);
        playerDetails.Enqueue(p2);
        playerDetails.Enqueue(p3);
        playerDetails.Enqueue(p4);
        playerDetails.Enqueue(p5);
        playerDetails.Enqueue(p6);
        playerDetails.Enqueue(p7);
        playerDetails.Enqueue(p8);
        playerDetails.Enqueue(p9);
        playerDetails.Enqueue(p10);
        playerDetails.Enqueue(p11);

        List<PlayerDetails> bowlers = new();
        bowlers.Add(p8);
        bowlers.Add(p9);
        bowlers.Add(p10);
        bowlers.Add(p11);

        Team team = new Team(name, playerDetails, new(), bowlers);
        return team;

    }


    private PlayerDetails addPlayer(String name, PlayerType playerType)
    {

        Person person = new Person();
        person.name = name;
        PlayerDetails playerDetails = new PlayerDetails(person, playerType);
        return playerDetails;
    }

}