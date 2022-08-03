using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VowelOrConsonant
{
    public static class UC9_VowelOrConsonant()
    {
        public static void CheckUC9_VowelOrConsonant()
        {

        char vowel;
        Console.WriteLine("Type Any Alphabet Down Here to Check Its Vowel or Consonant");
        vowel = Convert.ToChar(Console.ReadLine());
        switch (vowel)
        {
            case 'a':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'e':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'i':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'o':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'u':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'A':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'E':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'I':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'O':
                Console.WriteLine(" Alphabet is vowel");
                break;
            case 'U':
                Console.WriteLine("The Alphabet is vowel");
                break;
            default:
                Console.WriteLine(" Alphabet is Consonant");
                break;
        }
    }
}
}



