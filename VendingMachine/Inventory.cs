namespace VendingMachine
{
    public class Inventory
    {
        ItemShelf[] inventory = null;
        private object space;

        public Inventory(int n)
        {
            inventory = new ItemShelf[n];
            initialEmptyInventory();
        }

        public ItemShelf[] getInventory()
        {
            return inventory;
        }

        public void setInventory(ItemShelf[] inventory)
        {
            this.inventory = inventory;
        }

        public void initialEmptyInventory()
        {
            int startCode = 101;
            for(int i=0; i<inventory.Length; i++)
            {
                ItemShelf shelf = new ItemShelf();
                shelf.setCode(startCode);
                shelf.setSoltOut(true);
                inventory[i] = shelf;
                startCode++;
            }
        }

        public void addItem(Item item, int codeNumber)
        {
            foreach (var itemShelf in inventory) {
                if (itemShelf.getCode() == codeNumber) {
                    if (itemShelf.IsSoldOut()) {
                        itemShelf.SetItem(item);
                        itemShelf.setSoltOut(false);
                    } else {
                        throw new Exception("already item is present, you can not add item here");
                    }
                }
            }
        }


        public Item getItem(int codeNumber) 
        {
            foreach (var itemShelf in inventory)
            {
                if (itemShelf.getCode() == codeNumber) {
                    if (itemShelf.IsSoldOut()) {
                        throw new Exception("item already sold out");
                    } else {
                        return itemShelf.GetItem();
                    }
                }
            }
            throw new Exception("Invalid Code");
        }

        public void updateSoldOutItem(int codeNumber)
        {
            foreach (var itemShelf in inventory)
            {
                if (itemShelf.getCode() == codeNumber)
                {
                    itemShelf.setSoltOut(true);
                }
            }
        }

    }
}
