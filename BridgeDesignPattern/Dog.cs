namespace BridgeDesignPattern
{
    public class Dog : LivingThings
    {
        public Dog(BreatheImplementor breatheImplementor) : base(breatheImplementor)
        {
            
        }
        public override void breatheProcess()
        {
            breatheImplementor.breathe();
        }
    }
}
