using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Net.Security;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Metrics;

namespace Övningsuppgifter
{
    internal class Program
    {
        static void Main(string[] args)
        {






            // Uppgift 30
          // Console.WriteLine("skriv en text");
          // string text = Console.ReadLine();
          // Console.WriteLine("skriv ett start index");
          // int startIndex = int.Parse(Console.ReadLine());
          // Console.WriteLine("skriv slut index");
          // int endIndex = int.Parse(Console.ReadLine());
          //
          // for (int i = 0; i < text.Length; i++)
          // {
          //     if (i >= startIndex && i <= endIndex) Console.ForegroundColor = ConsoleColor.Red;
          //     else Console.ForegroundColor = ConsoleColor.Gray;
          //     Console.Write(text[i]);
          //
          // }



            // Uppgift 29
            // Console.WriteLine("skriv en text");
            // string text = Console.ReadLine();
            // Console.WriteLine("skriv en bokstav");
            // char letter = char.Parse(Console.ReadLine());
            //
            // for (int i = 0; i < text.Length; i++)
            // {
            //     if (text[i] == letter) Console.ForegroundColor = ConsoleColor.Red;
            //     else Console.ForegroundColor = ConsoleColor.Gray;
            //     Console.Write(text[i]);
            // 
            // }



            // uppgift 7
            // int zero = 0;
            // do
            // {
            //     zero++;
            //     if (zero % 3 == 0)
            //     {
            //
            //         Console.WriteLine("hej");
            //     }
            //     else
            //     {
            //         Console.WriteLine(zero);
            //     }
            //
            // } while (zero < 30);



            // Uppgift 6
            // int zero = 0;
            // do
            // {
            //     zero++;
            //     if (zero % 2 == 0)
            //     {
            //         
            //         Console.WriteLine(zero);
            //     }
            //
            // } while (zero < 30);

            // uppgift 5
            //   int twenty = 20;
            //   do
            //   {
            //       twenty++;
            //       Console.WriteLine(twenty);
            //   } while (twenty < 30);






            // uppgift 70 inte helt klar 
            //  void RockPaperScissor()
            //  {
            //      
            //     Random random = new Random();
            //     int pcChoice = random.Next(1, 3);
            //     Console.WriteLine("skriv 1 för sten");
            //     Console.WriteLine("skriv 2 för sax");
            //     Console.WriteLine("skriv 3 för påse");
            //     int val = int.Parse(Console.ReadLine());
            //     int myPoints = 0;
            //     int pcPoints = 0;
            //     bool gameLoop = false;
            //     int sten = 1;
            //     int sax = 2;
            //     int påse = 3;
            //     Console.WriteLine("datorn har nuvarande " + pcPoints + " poäng");
            //     Console.WriteLine("du har nuvarnade" + myPoints + " poäng");
            //     while (!gameLoop)
            //     {
            //
            //     if (val == pcChoice)
            //     {
            //         Console.WriteLine("lika inga poäng");
            //     }
            //     else if (val == 1 && pcChoice == 2)
            //     {
            //         Console.WriteLine("Grattis poäng till dig!");
            //         myPoints++;
            //     }
            //     else if (val == 2 && pcChoice == 1)
            //     {
            //         Console.WriteLine("poäng till datorn");
            //         pcPoints++;
            //     }
            //     else if (val == 3 && pcChoice == 1)
            //     {
            //         Console.WriteLine("Grattis poäng till dig!");
            //         myPoints++;
            //     }
            //     else if(val == 1 && pcChoice == 3)
            //     {
            //         Console.WriteLine("poäng till datorn");
            //         pcPoints++;
            //     }
            //     else if (val == 2 && pcChoice == 3)
            //     {
            //         Console.WriteLine("Grattis poäng till dig!");
            //         myPoints++;
            //     }
            //     else if (val == 3 && pcChoice == 2)
            //     {
            //         Console.WriteLine("poäng till datorn");
            //         pcPoints++;
            //     }
            //     }
            //     
            // }
            // RockPaperScissor();




            // uppgift 67
            //  double CelsiusToFarenheit(double celcius)
            //  {
            //      return celcius * 1.8 + 32;
            //  }
            //  Console.WriteLine($"i farenheit blir det {CelsiusToFarenheit(47)} grader");


            // upggift 64
            //  double DoubleAvarage(params int[] average)
            //  {
            //      
            //      return average.Sum() / average.Length;
            //  }
            //  Console.WriteLine(DoubleAvarage(4, 5, 7 ,8, 9, 10));








            //uppgift 63
            //  string MyJoin(string cities)
            //  {
            //      string newCities = cities.Replace(" ", "-->");
            //      return newCities;
            //  }
            //  Console.WriteLine(MyJoin("göteborg stockholm malmö"));







            // uppgift 62
            //  bool TrueOrFalse (string stringLength, int intLength)
            //  {
            //     int length = stringLength.Length;
            //      if (length > intLength)
            //      {
            //          return true;
            //      }
            //
            //      return false;
            //  }
            //  Console.WriteLine(TrueOrFalse("hejsan", 2));



            // uppgift 59 hela
            //  Console.Write("mata in en mening: ");
            //  string inmatad = Console.ReadLine();
            //  string[] enskildaOrd = inmatad.Split(' ');
            //  foreach (string ord in enskildaOrd)
            //  {
            //      Console.WriteLine(CamelCasing(ord));
            //  }
            //
            //
            //
            //
            //  string CamelCasing(string text)
            //  {
            //      string input = text.Replace(" ", String.Empty);
            //      char upperCase = text[0];
            //
            //
            //      return ($"{upperCase.ToString().ToUpper()}{input.Substring(1).ToLower()}");
            //  }



            // början av uppgift 59
            //  string CamelCasing(string text)
            //  {
            //
            //
            //
            //      string input = text.Replace(" ", String.Empty);
            //      char upperCase = text[0];
            //
            //      return ($"{upperCase.ToString().ToUpper()}{input.Substring(1).ToLower()}");
            //
            //
            //  }
            //  Console.WriteLine(CamelCasing("hej mitt namn är"));




            // gör tsm med uppgift 8 detta var uppgift 59
            // string MultiNumbers(int firstNumber, int secondNumber)
            // {
            //     
            //     return ($" {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            //     
            // }
            //
            // Console.WriteLine(MultiNumbers(3,4));



            // Uppgift 57
            //  string CallName(string firstName = "Pontus", string lastName = "Lann")
            //  {   
            //      return (firstName + " " + lastName);
            //  }
            //
            //  Console.WriteLine(CallName());




            // uppgift 56
            //  void CallName(string firstName, string lastName)
            //  {
            //      Console.WriteLine($"{firstName} {lastName}");
            //  }
            //  CallName("pontus", "lann");








            // uppgift 15 random num game
            //   Random rnd = new Random();
            //   int rndNum = rnd.Next(0, 100);
            //
            //
            //   Console.WriteLine("Du ska gissa på ett tal mellna 1-100");
            //   
            //   int numberOfGuesses = 0;
            //   bool correct = false;
            //
            //   while (!correct)
            //   {
            //
            //       int numb = int.Parse(Console.ReadLine());
            //       Console.WriteLine("du skrev " + numb);
            //       
            //     if (numb == rndNum)
            //     {
            //           
            //           Console.WriteLine($"Grattis rätt nummer var {rndNum} du gissade {numberOfGuesses} ggr");
            //     }
            //     else if (numb < rndNum)
            //     {
            //         Console.WriteLine(numb + " är lägre än talet som sökes");
            //         
            //           
            //     }
            //     else if (numb > rndNum)
            //     {
            //           Console.WriteLine(numb + " är högre än talet som sökes");
            //     }
            //       numberOfGuesses++;
            //   } 











            //   uppgift 28 ej korrekt?
            //  string name = Console.ReadLine();
            //  Console.WriteLine(name.Remove(3));





            // Uppgift 27 dock ej korrekt?
            // string newString = "Hello world";
            // Console.WriteLine(newString.Remove(1));
            // Console.WriteLine(newString.Remove(2));
            // Console.WriteLine(newString.Remove(3));
            // Console.WriteLine(newString.Remove(4));
            // Console.WriteLine(newString.Remove(5));
            // Console.WriteLine(newString.Remove(6));
            // Console.WriteLine(newString.Remove(7));
            // Console.WriteLine(newString.Remove(8));
            // Console.WriteLine(newString.Remove(9));
            // Console.WriteLine(newString.Remove(10));
            // Console.WriteLine(newString.Remove(11));



















            //   Uppgift 20 miniräknare
            //   Console.WriteLine("Skriv ett valfritt tal");
            //   int num = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv + om du vill addera");
            //   Console.WriteLine("skriv - om du vill subtrahera");
            //   Console.WriteLine("skriv * om du vill multiplicera");
            //   Console.WriteLine("skriv / om du vill dividera");
            //   string calc = Console.ReadLine();
            //
            //   if (calc == "+")
            //   {
            //       Console.WriteLine("skriv ditt andra tal du vill adddera" + num + " med");
            //       int add = int.Parse(Console.ReadLine());
            //       int sum1 = num + add;
            //       Console.WriteLine("din summa blir " + sum1);
            //   }
            //   else if (calc == "-")
            //   {
            //       Console.WriteLine("skriv vilket tall du vill subtrahera " + num + " med");
            //       int sub = int.Parse(Console.ReadLine());
            //       int sum2 = num - sub;
            //       Console.WriteLine("din summa blir " + sum2);
            //   }
            //   else if (calc == "*")
            //   {
            //       Console.WriteLine("skriv vilket tall du vill multiplicera " + num + " med");
            //       int multi = int.Parse(Console.ReadLine());
            //       int sum3 = num * multi;
            //       Console.WriteLine("din summa blir " + sum3);
            //   }
            //   else if (calc == "/")
            //   {
            //       Console.WriteLine("skriv vilket tall du vill dividera " + num + " med");
            //       int div = int.Parse(Console.ReadLine());
            //       int sum4 = num / div;
            //       Console.WriteLine("din summa blir " + sum4);
            //   }
            //   else
            //   {
            //       Console.WriteLine("error try again");
            //   }







            //  uppgift 53 nästan avklarad något litet bug
            //   Console.WriteLine("Skriv fem nummer med , emellan");
            //   string newString = Console.ReadLine();
            //   string[] word = newString.Split(' ');
            //   Array.Sort(word);
            //   foreach (string word2 in word)
            //   {
            //       
            //       Console.WriteLine(word2.Replace(",", ""));     // nästannnnnn
            //   }













            // uppgift 52
            //   int[] ints = new int[10];
            //   Console.WriteLine("skriv in första talet");
            //   ints[0] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in andra talet");
            //   ints[1] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in tredje talet");
            //   ints[2] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in fjärde talet");
            //   ints[3] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in femte talet");
            //   ints[4] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in sjätte talet");
            //   ints[5] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in sjunde talet");
            //   ints[6] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in åttonde talet");
            //   ints[7] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in nionde talet");
            //   ints[8] = int.Parse(Console.ReadLine());
            //   Console.WriteLine("skriv in tionde talet");
            //   ints[9] = int.Parse(Console.ReadLine());
            //
            //
            //   Array.Sort(ints);
            //   Console.WriteLine("i ordning efter storlek ");
            //   foreach (int i in ints)
            //   {
            //       Console.WriteLine(i + " ");
            //   }





            //  Console.WriteLine("skriv nummer 1");
            //  int num1 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 2");
            //  int num2 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 3");
            //  int num3 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 4");
            //  int num4 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 5");
            //  int num5 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 6");
            //  int num6 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 7");
            //  int num7 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 8");
            //  int num8 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 9");
            //  int num9 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv nummer 10");
            //  int num10 = int.Parse(Console.ReadLine());

            // uppgift 50
            // string newString = Console.ReadLine();
            // Console.WriteLine(newString.Replace(" ", "_"));







            // Kom ihåg att göra uppgift 20 samt 49 de hör ihop







            //    Uppgift 47
            //    Console.WriteLine("skriv in ditt namn");
            //    string name = Console.ReadLine();
            //    string[] words = name.Split(' ');
            //    foreach (string word in words)
            //    {
            //        Console.WriteLine(word);
            //    }






            //   uppgift 25 (egentligen ska en loop utföras med detta är enklare) 
            //  string name = "Hello world";
            //  Console.WriteLine(name.Replace("o", "x"));




            //     Uppgift 24 reverse string
            //    char[] charArray = "Hello World".ToCharArray();
            //    Array.Reverse(charArray);
            //    Console.WriteLine(new string(charArray));
            //







            // uppgift 44
            //  Console.WriteLine("skriv ett tal 1-10");
            //  int längd = int.Parse(Console.ReadLine());
            //  Console.WriteLine("skriv ett tal 1-10");
            //  int bredd = int.Parse(Console.ReadLine());
            //
            //  double pyth1 = Math.Pow(längd, 2);
            //  double pyth2 = Math.Pow(bredd, 2);
            //  Console.WriteLine(pyth1 + pyth2);





            //         Console.WriteLine(remove_char("w3resource", 1));
            //         Console.WriteLine(remove_char("w3resource", 9));
            //         Console.WriteLine(remove_char("w3resource", 0));
            //     }
            //     public static string remove_char(string str, int n)
            //     {
            //         return str.Remove(n, 1);
            //     }






            // uppgift 7 loop
            //        Console.WriteLine("Skriv bredd");
            //        int x = int.Parse(Console.ReadLine());
            //        Console.WriteLine("skriv höjd");
            //        int y = int.Parse(Console.ReadLine()); 
            //
            //        for (int i = 0; i < y; i++)
            //        {
            //
            //            Console.WriteLine();
            //            for (int j = 0; j < x; j++)
            //            {
            //                if (i % 2 == 0)
            //                {
            //
            //                if (j % 2 == 0)
            //                {
            //                    Console.Write("X");
            //
            //                }
            //                else 
            //                {
            //                    Console.Write("O");
            //                }
            //                }
            //                else
            //                {
            //                    if (j % 2 == 1)
            //                    {
            //                        Console.Write("X");
            //
            //                    }
            //                    else
            //                    {
            //                        Console.Write("O");
            //                    }
            //                }


            //    }









            // Uppgift 6
            //Console.WriteLine("skriv en bredd");
            //int bredd = int.Parse(Console.ReadLine());
            //Console.WriteLine("skriv en höjd");
            //int höjd = int.Parse(Console.ReadLine());

            //for (int i = 0; i < höjd; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < bredd; j++)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            Console.Write("X");
            //        else
            //        {
            //            Console.Write("O");
            //        }
            //    }

            //}














            // uppgift 5 loopar
            //     Console.WriteLine("skriv en bredd");
            //     int bredd = int.Parse(Console.ReadLine());
            //     Console.WriteLine("skriv en höjd");
            //     int höjd = int.Parse(Console.ReadLine());
            //
            //    for (int i = 0; i < höjd; i++)
            //     {
            //         Console.WriteLine();
            //         for (int j = 0; j < bredd; j++)
            //         {
            //             Console.Write("X");
            //         }
            //
            //     }









            // Uppgift 4 loopar
            //        Console.WriteLine(" skriv in ett tal:");
            //         int tal = int.Parse(Console.ReadLine());
            //
            //
            //        
            //        for (int i = 2; i <= 10; i++)
            //        {
            //            
            //            Console.WriteLine(tal * i);
            //        }








            // uppgift 3 loopar
            //        for (int i = 0; i <= 30; i++)
            //        {
            //            if (i % 3 == 0)
            //            {
            //                Console.WriteLine("hej");
            //            }
            //            else
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }







            // uppgift 2 loop
            //        for (int i = 0; i <= 30; i+=2)
            //        {
            //            
            //            Console.WriteLine(i);
            //        }










            // Uppgift 3
            //                Console.WriteLine("skriv in ditt förnamn");
            //                string förNamn = Console.ReadLine();
            //
            //       bool isPontus = (förNamn == "Pontus");
            //                if (isPontus)
            //                {
            //                    Console.WriteLine("Hej, du är personen jag tänkte på");
            //                }
            //                else 
            //                {
            //                    Console.WriteLine("vem är du?");
            //                }










        }
    }
}