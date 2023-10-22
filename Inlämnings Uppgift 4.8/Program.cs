using System;

namespace Uppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string hittade = "";
            Console.WriteLine("Skriv en sträng med text");
            String text = Console.ReadLine().ToLower();
            Console.WriteLine("Skriv in två tecken");
            String tecken = Console.ReadLine().ToLower();

            for (int i = 0; i < tecken.Length; i++)
            {
                char först = tecken[i];
                for (int j = 0; j < text.Length; j++)
                {
                    char sist = text[j];

                    if (först == sist)
                    {
                        hittade = hittade + först;
                    }
                }
            }
            if (hittade == tecken)
            {
                Console.WriteLine("Båda bokstäverna finns");
            }
            else
            {
                Console.WriteLine("Båda tecken fanns inte");
            }
        }
    }
}