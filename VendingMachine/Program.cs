
namespace VendingMachine {
    public class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            try
            {

                Console.WriteLine("|");
                Console.WriteLine("filling up the inventory");
                Console.WriteLine("|");

                fillUpInventory(vendingMachine);
                displayInventory(vendingMachine);

                Console.WriteLine("|");
                Console.WriteLine("clicking on InsertCoinButton");
                Console.WriteLine("|");

                VendingStates.IState vendingState = vendingMachine.getVendingMachineState();
                vendingState.clickOnInsertCoinButton(vendingMachine);

                vendingState = vendingMachine.getVendingMachineState();
                vendingState.insertCoin(vendingMachine, Coin.Nickel);
                vendingState.insertCoin(vendingMachine, Coin.Quarter);
                // vendingState.insertCoin(vendingMachine, Coin.NICKEL);

                Console.WriteLine("|");
                Console.WriteLine("clicking on ProductSelectionButton");
                Console.WriteLine("|");
                vendingState.clickOnStartProductSelectionButton(vendingMachine);

                vendingState = vendingMachine.getVendingMachineState();
                vendingState.chooseProduct(vendingMachine, 102);

                displayInventory(vendingMachine);

            }
            catch (Exception e)
            {
                displayInventory(vendingMachine);
            }

        }

        private static void fillUpInventory(VendingMachine vendingMachine)
        {
            ItemShelf[] slots = vendingMachine.GetInventory().getInventory();
            for (int i = 0; i < slots.Length; i++)
            {
                Item newItem = new Item();
                if (i >= 0 && i < 3)
                {
                    newItem.setType(ItemType.Coke);
                    newItem.setPrice(12);
                }
                else if (i >= 3 && i < 5)
                {
                    newItem.setType(ItemType.Pepsi);
                    newItem.setPrice(9);
                }
                else if (i >= 5 && i < 7)
                {
                    newItem.setType(ItemType.Juice);
                    newItem.setPrice(13);
                }
                else if (i >= 7 && i < 10)
                {
                    newItem.setType(ItemType.Soda);
                    newItem.setPrice(7);
                }
                slots[i].SetItem(newItem);
                slots[i].setSoltOut(false);
            }
        }


        private static void displayInventory(VendingMachine vendingMachine)
        {
            ItemShelf[] slots = vendingMachine.GetInventory().getInventory();
            for (int i = 0; i < slots.Length; i++)
            {

                Console.WriteLine("CodeNumber: " + slots[i].getCode() +
                        " Item: " + slots[i].GetItem().getType().ToString() +
                        " Price: " + slots[i].GetItem().getPrice() +
                        " isAvailable: " + !slots[i].IsSoldOut());
            }
        }

    }
}