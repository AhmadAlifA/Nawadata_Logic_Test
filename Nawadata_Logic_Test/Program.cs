using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawadata_Logic_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            no1();
            no2();
        }

        static void no1() {
            Console.Write("Input one line of words (S) : ");
            string word = Console.ReadLine().ToLower();
            string vowels = "";
            string Consonant = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'i' || word[i] == 'u' || word[i] == 'e' || word[i] == 'o') vowels += word[i];
                else if (word[i] == ' ') { }
                else Consonant += word[i];
            }
            Console.WriteLine();
            Console.WriteLine("Vowel Characters: ");
            Console.WriteLine(vowels);
            Console.WriteLine("Consonant Characters: ");
            Console.WriteLine(Consonant);
            Console.ReadLine();
        }
        static void no2()
        {
            Console.Write("Input the number of families: ");
            int numberOfFamilies = int.Parse(Console.ReadLine());

            Console.Write("Input the number of members in the family (separated by a space): ");
            string[] membersInput = Console.ReadLine().Split(' ');

            if (membersInput.Length != numberOfFamilies)
            {
                Console.WriteLine("Input must be equal to the count of families.");
                Console.ReadLine();
                return;
            }

            int membersPerFamily = 0;
            for (int i = 0; i < numberOfFamilies; i++)
            {
                membersPerFamily += int.Parse(membersInput[i]);
            }

            int totalMembers = 0;
            int busesRequired = 0;

            while (membersPerFamily >= 4)
            {
                busesRequired++;
                membersPerFamily = membersPerFamily - 4; // Mereset jumlah anggota di bus
            }

            if (membersPerFamily > 0)
            {
                Console.WriteLine(membersPerFamily);
                busesRequired++;
            }

            Console.WriteLine("Minimum bus required is: " + busesRequired);
            Console.ReadLine();
        }
    }
}
