using System;

namespace LoveLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFeelings = "unendlich";
            string you = "mein Herz";
            
            Console.WriteLine("Dear {0},", you);
            Console.WriteLine();
            Console.WriteLine("Seit dem Moment, als du in mein Leben getreten bist, hat sich alles verändert. ");
            Console.WriteLine("Meine Liebe zu dir ist wie eine Schleife:");
            
            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine("Ich liebe dich! ({0})", i + 1);
            }
            
            Console.WriteLine();
            Console.WriteLine("Du bist der \"true\" Wert in meinem Boolean-Leben.");
            Console.WriteLine("Ohne dich wäre mein Code voller Errors.");
            Console.WriteLine("Mit dir fühlt sich alles wie ein perfekt kompiliertes Programm an.");
            Console.WriteLine();
            Console.WriteLine("Du bist nicht nur {0}, du bist mein gesamtes Universum.", you);
            Console.WriteLine("Mit Liebe,");
            Console.WriteLine("Dein {0}", Environment.UserName);
        }
    }
}
