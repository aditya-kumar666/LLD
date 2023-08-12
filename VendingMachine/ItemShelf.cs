namespace VendingMachine
{
    public class ItemShelf
    {
        int code;
        Item item;
        bool soldOut;

        public int getCode()
        {
            return code;
        }

        public Item GetItem()
        {
            return item;
        }

        public void SetItem(Item item)
        {
            this.item = item;
        }

        public bool IsSoldOut()
        {
            return soldOut;
        }

        public void setSoltOut(bool soltOut)
        {
            this.soldOut = soltOut;
        }

        public void setCode(int code)
        {
            this.code = code;
        }
    }
}
