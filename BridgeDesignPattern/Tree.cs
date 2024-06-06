namespace BridgeDesignPattern
{
    public class Tree : LivingThings
    {
        public Tree(BreatheImplementor breatheImplementor) : base(breatheImplementor)
        {

        }
        public override void breatheProcess()
        {
            breatheImplementor.breathe();
        }
    }
}
