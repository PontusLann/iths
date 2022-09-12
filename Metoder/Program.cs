using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Metoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void printHelloWorld()                                        // en metod utan parametrar
            {                                                             //
                Console.WriteLine("hello");                               //
                Console.WriteLine("world");                               //
            }
            printHelloWorld();


          //  void printGreetings(string name)                               // en metod med en parameter name som ska skrivas in i metod när den anropas
          //  {                                                              //
          //      Console.WriteLine($"hello {name}");                        //
          //  }                                                              //
          //  printGreetings("Pontus");                                      // "Pontus" blir då argumentet för parametern i metoden




            void printGreetingsMultipleTimes(string name, int numberOfPrints = 1)    //  Name är argumentet för stängen i detta ex "Pontus"
            {                                                                        //
                for (int i = 0; i < numberOfPrints; i++)                             // numberOfPrints är argumentet för hur många ggr den ska skrivas
                {                                                                    //
                Console.WriteLine($"hello {name}");                                  // går även att göra paramentern numberOfPritns valbar genom att
                }                                                                    //ge den ett värde så skulle man ej skriva argument för 
            }                                                                        // numberOfPrints hade default värdet varit en gång
            printGreetingsMultipleTimes("Pontus", 5);


            void printGreetingsMultipleTimes2(string name, int numberOfPrints, bool exlemationMark)   // likt den första kan man bestämma hur många ggr
            {                                                                                         // metoden skall skrivas fast med en bool också
                                                                                                      // finns olika sätt att lösa boolen
                for (int i = 0; i < numberOfPrints; i++)                                              // detta ex använder if sats för om bool är
                {                                                                                     // sann eller falsk
                                                                                                      // vid sann ska 3 !!! skrivas ut 
                    if (exlemationMark)                                                               // vid falsk ska vanliga strängen skrivas
                    {                                                                                 //
                        Console.WriteLine($"Greetins {name}!!!");                                     //
                    }                                                                                 //
                    else                                                                              //
                    {                                                                                 //
                        Console.WriteLine($"Greetins {name}");                                        //
                    }                                                                                 //
                }                                                                                     
                                                                                                      
            }
            printGreetingsMultipleTimes2("pontus", 1, false);                                         //
                                                                                                      //
            int AddFive(int number)                                                                   //
            {                                                                                         //
                return number + 5;                                                                    //
            }                                                                                         //
            int result = AddFive(7);                                                                  // båda sätten funkar men då resault är lite
            Console.WriteLine(result);                                                                // mer lätt läst och lättare att förstå
            Console.WriteLine(AddFive(7));                                                            // men båda funkar




            int Sum(params int[] numbers)
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                return sum;

            }
            Console.WriteLine(Sum(3,4));









        }

          // För metoder/funktioner skall man använda pascalcase EX HejMittNamnÄr aka stor bokstav vid nytt ord
          //// för lokala variabler skall man använda camelcase EX hejMittNamnÄr aka stor bokstav vid nytt ord men liten bokstav första
        
          

       


    }
}