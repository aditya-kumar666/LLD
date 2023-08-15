namespace CricBuzz.Team
{
    public class Wicket
    {
        public WicketType wicketType;
        public PlayerDetails takenBy;
        public OverDetail overDetail;
        public BallDetail ballDetail;

        public Wicket(WicketType wicketType, PlayerDetails takenBy, OverDetails overDetail, BallDetails ballDetail)
        {
            this.wicketType = wicketType;
            this.takenBy = takenBy;
            this.overDetail = overDetail;
            this.ballDetail = ballDetail;
        }
    }
}
