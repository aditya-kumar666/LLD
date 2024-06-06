using BridgeDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        LivingThings fish = new Fish(new WaterBreatheImplementation());
        fish.breatheProcess();
    }
}