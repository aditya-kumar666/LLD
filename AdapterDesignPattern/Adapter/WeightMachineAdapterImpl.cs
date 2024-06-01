using AdapterDesignPattern.Adaptee;

namespace AdapterDesignPattern.Adapter
{
    public class WeightMachineAdapterImpl : WeightMachineAdapter
    {
        WeightMachine weightMachine;
        public WeightMachineAdapterImpl(WeightMachine wm)
        {
            weightMachine = wm;
        }

        public double getWeightInKg()
        {
            double wtInPound = weightMachine.getWeightInPound();
            return wtInPound*0.45;
        }
    }
}
