using System.Text;

namespace Anagrams
{
    internal class Program
    {
        static void SortChars(char[]? c)
        {
            if (c == null) return;
            for (int i = 0; i < c.Length-1; i++)
            {
                for (int j = i + 1; j < c.Length; j++)
                {
                    if(c[i]>c[j])(c[i], c[j]) = (c[j], c[i]);
                }
            }
        }
        static bool IsAnagram(string? s1, string? s2)
        {
            if (s1 == null || s2 == null) return false;
            if (s1 == s2) return true;
            if(s1.Length != s2.Length) return false;

            char[] arr1 = s1.ToLower().ToCharArray();
            char[] arr2 = s2.ToLower().ToCharArray();

            SortChars(arr1);
            SortChars(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            // Program compares if two words are anagrams
            // Compares numbers and symbols too
            // TODO: add string verification
            Console.WriteLine(IsAnagram(Console.ReadLine(), Console.ReadLine()));
        }
    }
}