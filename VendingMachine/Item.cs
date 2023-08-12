namespace VendingMachine
{
    public class Item
    {
        ItemType type;
        int price;

        public ItemType getType()
        {
            return type;
        }

        public int getPrice()
        {
            return price;
        }

        public void setPrice(int price) {
            this.price = price;
        }

        public void setType(ItemType type)
        {
            this.type = type;
        }
    }
}
