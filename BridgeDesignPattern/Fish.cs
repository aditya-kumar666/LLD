namespace BridgeDesignPattern
{
    public class Fish : LivingThings
    {
        public Fish(BreatheImplementor breatheImplementor) : base(breatheImplementor)
        {

        }
        public override void breatheProcess()
        {
            breatheImplementor.breathe();
        }
    }
}
