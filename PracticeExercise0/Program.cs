using System;
using System.Linq;

namespace PracticeExcercise0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("mom "));
            Console.WriteLine(IsPalindrome("Mom"));
            Console.WriteLine(IsPalindrome("Race car"));
            Console.WriteLine(IsPalindrome("A nut for a jar of tuna"));

            Console.WriteLine(Reverse("coffee"));
            Console.WriteLine(Reverse("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(Reverse("Dad"));
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse("savannaH"));

            Console.WriteLine(ReverseInt(369));

            Console.WriteLine(IsUnique("mom"));
            IsUnique("");
            IsUnique("mom");
            IsUnique("Robbie");
            Console.WriteLine(IsUnique("Judah"));

            Console.WriteLine(IsNeilNumber(371));
            Console.WriteLine(IsNeilNumber(24));

        }


        // #1
        public static bool IsPalindrome(string s)
        {
            // clean up string
            // remove spaces
            // lowercase it
            string cleanString = s.ToLower().Replace(" ", "");

            // reverse the clean string
            string reversed = Reverse(cleanString);

            // check if the reverse string is the same as the clean string
            return reversed == cleanString;       
        }

        private static string Reverse(string s)
        {
            string result = "";

            foreach (char c in s)
            {
                result = result.Insert(0, c.ToString());
            }
            

            return result;
        }

        // #2 
        public static int ReverseInt(int i)
        {
            int reversed = 0;
            while( i != 0)
            {
                reversed = reversed * 10 + i % 10;
                i = i / 10;
            }

            return reversed;
        }

        // #3
        public static bool IsUnique(string s)
        {
            string cleanString = s.ToLower().Replace(" ", "");
            for(int i = 0; i < cleanString.Length; i++)
            {
                for(int j = i + 1; j < cleanString.Length; j++)
                {
                    if (cleanString[i] == cleanString[j])
                    {
                        return false;
                    }
                }
            }

            
            return true;
        }


        // #4
        public static bool IsNeilNumber(int i)
        {
            int iCopy = i;
            int toAdd = 0;
            string iLength = i.ToString();
            while (i > 0)
            {
                int squared = (int)Math.Pow(i % 10, iLength.Length);
                toAdd += squared;

                i /= 10;
            }
            if (toAdd == iCopy)
            {
                return true;
            }
            return false;
        }
    }
}
