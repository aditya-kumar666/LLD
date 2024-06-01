using AdapterDesignPattern.Adaptee;
using AdapterDesignPattern.Adapter;

public class Client
{
    public static void Main(string[] args)
    {
        WeightMachineAdapter adapter = new WeightMachineAdapterImpl(new WeightMachineForBabies());
        Console.WriteLine(adapter.getWeightInKg());
    }
}