using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace iths
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // signed

            sbyte mySbyte = 8;      //olika variabeltyper max range +-2^8/2

            short myShort = 16;     // olika variabeltyper max range +-2^16/2

            int myInt = 32;         // olika variabeltyper max ranger ca +-2,1 miljarder

            long myLong = 64;       // olika variabeltyper max range ca +-2^63/2


            // Unsigned

            byte myByte = 8;       // range 0 --> 2^8 = 256

            ushort myUShort = 16;  //  range 0 --> 2^16 = 65536

            uint myUint = 32;      // range 0 --> 2^32 = 4 294 967 296

            ulong myULong = 64;    // range 0 --> 2^64 = 18 446 744 073 709 551 616

            // datatyp som lagrar siffror som inte är heltal

            float myFloat = 3.14f;           // 32 bitar

            double myDouble = 3.14;         // 64 bitar

            decimal myDecimal = 3.14M;      // 128 bitar 

            // Implicit typad variabel (med keyword var)
            var x = 5L;

            // Suffix
            // f för float (ex: 0.5f)
            // M för decimal (ex: 0.5M)
            // l för long (ex: 0.5l)
            //

            String myStringDotNet = "används för att lagra text";
            string myString = "används för att lagra text";

            Char myCharDotNet = '2';      // lagrar tecken (ett tecken)
            char myChar = '5';

            Boolean myBoolean = false;   // endast true or false
            bool myBool = true;

            // variabler

            // initzierar kan göras efter måste assigne först

            int k;
            k = 5;

            // funkar ej för (var)

            // Scope

            string firstName = "Fredrik";

            if (firstName == "Fredrik")
            {
                string lastName = "Johansson";
                if (lastName == "Johansson")
                {
                    int age = 41;
                    Console.WriteLine($"{firstName} {lastName}");

                }

            }



            // Mtheod/Function Scope: Variabler är endast giltiga i funktionen/metoden de deklareras i.
            void myFunction()
            {
                string text = "hejsan";
                Console.WriteLine(text);
            }

            ///////////////////////////
            ///
            //  int[] evenNumbers = { 2, 4, 6, 8, 10 };
            //
            //  foreach(var numb in evenNumbers) /// en for loop med kotare syntax för att skirv ut en array
            //  {
            //      Console.WriteLine(numb);
            //  }
            //  for (int i = 0; i < evenNumbers.Length; i++) /// andra medtoden för att skriva ut en array
            //  {
            //      Console.WriteLine(i);
            //  }   

            // string text = "hello world";  // en string kan ses som en "array" byggd av flera bokstäver
            //
            // foreach (char c in text)  // likt en arrray kan man "komma åt varje bokstav för sig".
            // {
            //     Console.WriteLine(c); // funkar även med vanlig for loop
            // }

            ////////////////////////////////////////////
            // console class

            // properties funkar mer som en varibel där man kan ändra på olika saker ex colour


            //    ConsoleColor myColor = Console.ForegroundColor;  // skriver "röd" i röd text
            //    Console.WriteLine("hej");
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("röd");
            //    Console.ForegroundColor = myColor;
            //    Console.WriteLine("the end");

            ///////////////////////////
            /// math class
            /// absolutbelopp
            Console.WriteLine(Math.Abs(-8)); // ger ett absoult belopp dvs - blir +
            // avrunding
            Console.WriteLine(Math.Ceiling(3.4f)); // närmsta heltal uppåt
            Console.WriteLine(Math.Floor(3.4f)); // närmsta heltal neråt
            Console.WriteLine(Math.Round(3.4f)); // avrundar tal
            Console.WriteLine(Math.Truncate(3.4f)); // likt celing tar truncate bort decimaler
            // min max clamp
            Console.WriteLine(Math.Min(5, 8)); // retunerar det minsta av parametrat
            Console.WriteLine(Math.Max(5, 8)); // retunerar det högsta av parametrar
            Console.WriteLine(Math.Clamp(5, 0, 100)); // retunerar värdet av en variabel mellan 0 - 100
            // power
            Console.WriteLine(Math.Pow(2, 4));  // upphöjt till ex 2^4 i detta ex
            Console.WriteLine(Math.Sqrt(9)); // roten ur

            /////////////////////////////////////
            ///string class
            string name = "pontus lann är kung";

            // replace / remove
            Console.WriteLine(name.Replace('p', 'a')); // byter ut char
            Console.WriteLine(name.Replace("pon", "k")); // kan även byta ur större delar av strängar
            Console.WriteLine(name.Insert(6, " jeboote")); // kan "inserta" en stäng eller char i en sträng 
            Console.WriteLine(name.Substring(4)); // "hoppar" in i en sträng och forstätter strängen efter det index som valts

            //name.Remove // för att ta allt efter en viss punkt i strängen ex (2) tar bort allt efter po
            Console.WriteLine(name.Remove(2));
            Console.WriteLine(name.Remove(2, 2)); // tar bort en viss index så från index 2 sen 2 char

            // upper / lower
            Console.WriteLine(name.ToLower());  // små bokstäver
            Console.WriteLine(name.ToUpper()); // stora bokstäver

            //split
            string[] words = name.Split(' ');        // välj vart rad bryt ska ske i dett fall vid mellanrum
            foreach (string word in words)           // gör det till array för att att kunna ske
            {
                Console.WriteLine($"{word}: {word.Length}");       // räknar ut antal tecken per line
            }

            // trim
            Console.WriteLine("      hej      ".TrimStart());   // tar bort alla mellanrum före strängen "white-space"
            Console.WriteLine("      hej      ".TrimEnd());     // tar bort alla mellanrum efter strängen "white-space"
            Console.WriteLine("      hej      ".TrimStart('j')); // kan även ta bort karaktärer ur en stäng
            Console.WriteLine("      hej      ".Trim());         // gör samma sak som trimEnd och trimStart utan att behöva skriva båda

            // indexOf
            Console.WriteLine(name.IndexOf("är"));   // söker efter första instansen av det angivna indexet. Sträng eller char
            Console.WriteLine(name.LastIndexOf("pontus")); // söker efter sista ^^

            //padleft - padright
            Console.WriteLine("hej".PadLeft(4));    // 4 white-spaces vänster
            Console.WriteLine("hej".PadRight(4));  // 4 white-spaces höger

            // String.
            string emptyString = String.Empty; // används som en konstant tom sträng = ""
            Console.WriteLine(String.Concat("pontus", "charles", "mustaffa")); // concatinerar eller sätter ihop flera strängar

            string[] städer = { "lanna", "bredaryd", "Forsheda" };   // .Join för att lägga till andra karaktärer i arrays eller strängar
            Console.WriteLine(String.Join(" - ", städer));


            // repetition
            int h = 1;
            int y = (h < 3 ? 0 : 1);        // som en bool kollar den om h < 3 så ska 0 skrivas (true) eller om h är större 1 (false)
            Console.WriteLine(y);
            Console.WriteLine(x);


            for (int i = 0; i < 20; i++)
            {
                // if (i % 2 == 0)                                                 // Istället för att göra en if statment kan man istället göra 
                // {                                                               // Bool grejen
                //     Console.Write("X");                                         // 
                // }                                                               // 
                // else                                                            // 
                // {                                                               // 
                //     Console.Write("O");                                         // 
                // }                                                               // 
                Console.WriteLine(i % 2 == 0 ? "X" : "O");                       // 
            }

            var users = 4;

            Console.WriteLine($"There are {users} user{(users == 1 ? "" : "s")}");  // kollar hur många users det är genom en bool

            Console.ReadKey(true);
        }
    }
}