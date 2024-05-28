namespace FlyweightDesignPattern
{
    public class DocumentCharacter : ILetter
    {
        private char character;
        private string fontType;
        private int size;

        public DocumentCharacter(char character, String fontType, int size)
        {
            this.character = character;
            this.fontType = fontType;
            this.size = size;
        }

        public void display(int row, int column)
        {
            //display the character of particular font and size
            //at given location
        }
    }
}
