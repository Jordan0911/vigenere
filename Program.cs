namespace vigenere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool found=false;   
            int t = 0,q=0,s=0,a=0;
            string word = "", worm = "";
            char[] alphabet= "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Console.WriteLine("insert the word");
            word=Console.ReadLine();
            Console.WriteLine("insert the worm");
            worm= Console.ReadLine();
            char[] worm_broken = worm.ToCharArray();
            char[] word_broken = word.ToCharArray();
            char[] wormed_word = new char[word_broken.Length];
            char[] coded_word= new char[word_broken.Length];    
            for (int i = 0; i < word.Length; i++) 
            {
                    if (t == worm_broken.Length)
                    {
                        t = 0;
                    }
                wormed_word[i] = worm_broken[t];
                t++;            
            }
            for(int i = 0;i < word_broken.Length; i++)
            {
                found = false;
                while (found == false)
                {
                    if (s == 26)
                    {
                        s = 0;
                    }
                    if (wormed_word[q] == alphabet[s])
                    {
                        a = s + 1;
                       
                        found = true;
                    }
                    q++;
                }
            }

        }
    }
}
