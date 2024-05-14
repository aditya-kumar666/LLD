namespace StackOverflow.Model
{
    public abstract class Entity
    {
        string entityId;
        string content;
        Member owner;
        Dictionary<VoteType, int> voteTypeCountMap;

        public Entity(string content, Member owner)
        {
            this.content = content;
            this.owner = owner;
            entityId = Guid.NewGuid().ToString();
            voteTypeCountMap = new Dictionary<VoteType, int>();
        }

        public string getEntityId()
        {
            return entityId;
        }

        public Member getOwner()
        {
            return owner;
        }

        public void setOwner(Member owner)
        {
            this.owner = owner;
        }

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
        }

        public Dictionary<VoteType, int> getVoteTypeCountMap()
        {
            return voteTypeCountMap;
        }

        public void setVoteTypeCountMap(Dictionary<VoteType, int> voteTypeCountMap)
        {
            this.voteTypeCountMap = voteTypeCountMap;
        }
    }
}
