using AdapterDesignPattern.Adaptee;
using AdapterDesignPattern.Adapter;

public class Client
{
    public static void Main(string[] args)
    {
        WeightMachine wm = new WeightMachineForBabies();
        Console.WriteLine(wm.getWeightInPound());

        WeightMachineAdapter adapter = new WeightMachineAdapterImpl(new WeightMachineForBabies());
        Console.WriteLine(adapter.getWeightInKg());
    }
}