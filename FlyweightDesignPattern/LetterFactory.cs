namespace FlyweightDesignPattern
{
    public class LetterFactory
    {
        private static Dictionary<char, ILetter> charCache = new Dictionary<char, ILetter>();

        public static ILetter createLetter(char letter)
        {
            if (charCache.ContainsKey(letter))
            {
                return charCache[letter];
            }
            else
            {
                DocumentCharacter charO = new DocumentCharacter(letter, "Arial", 10);
                charCache.Add(letter, charO);
                return charO;
            }
        }
    }
}
