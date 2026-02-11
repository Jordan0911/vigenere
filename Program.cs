namespace vigenere
{
    internal class Program
{
    static int Space_jumper(char[] alphabet, char[] word,int location)
    {

        bool found=false;
        int s = 0,t=0;
        
        found = false;
        while (found == false)
        {
            if (s == 26)
            {
                s = 0;
            }
            if (word[location] == alphabet[s])
            {
                found = true;
            }
            s++;
            t++;
        }
        return t;
    }
    static void Main(string[] args)
    {
        int t = 0,spaces_to_jump=0,letter_location=0,q=0;
        string word = "", worm = "",code="";
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        Console.WriteLine("insert the word");
        word = Console.ReadLine();
        Console.WriteLine("insert the worm");
        worm = Console.ReadLine();
        char[] worm_broken = worm.ToCharArray();
        char[] word_broken = word.ToCharArray();
        char[] wormed_word = new char[word_broken.Length];
        char[] coded_word = word_broken;

            for (int i = 0; i < word.Length; i++)
            {
                if (t == worm_broken.Length)
                {
                    t = 0;
                }
                wormed_word[i] = worm_broken[t];
                t++;
            }
        for (int i = 0; i < word_broken.Length; i++)
        {
            if (i > wormed_word.Length)
            {
                q = 0;
            }
            letter_location = Space_jumper(alphabet, coded_word, i);
            spaces_to_jump = letter_location + Space_jumper(alphabet, wormed_word, q);
            if (letter_location + spaces_to_jump > 26)
            {
                spaces_to_jump -= 26;
            }
            else
            {
                coded_word[i] = alphabet[letter_location + spaces_to_jump];
            }
            q++;
        }
        code = string.Join("",coded_word);
        Console.WriteLine(code);
    }
}
