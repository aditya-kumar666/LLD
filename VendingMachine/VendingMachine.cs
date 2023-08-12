using VendingMachine.VendingStates;

namespace VendingMachine
{
    public class VendingMachine
    {
        IState vendingMachineState;
        Inventory inventory;
        List<Coin> coinList;
        public VendingMachine() {
            vendingMachineState = new IdleState();
            inventory = new Inventory(10);
            coinList = new List<Coin>();
        }

        public IState getVendingMachineState()
        {
            return vendingMachineState;
        }

        public void setVendingMAchineState(IState vendingMachineState)
        {
            this.vendingMachineState = vendingMachineState;
        }

        public Inventory GetInventory()
        {
            return inventory;
        }

        public void setInventory(Inventory inventory)
        {
            this.inventory = inventory;
        }
        public List<Coin> getCoinList()
        {
            return coinList;
        }

        public void setCoinList(List<Coin> coinList)
        {
            this.coinList = coinList;
        }
    }
}
