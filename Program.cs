using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Labb_1
{
    internal class Program
    {
            
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Vill du testa exempel strängen från labben eller hitta på en egen?");
            Console.WriteLine("Tryck på \"Y\" om vill köra exempel strängen \"N\" om du vill skriva en egen");
            char exampelString = char.Parse(Console.ReadLine());


            if (exampelString == 'y')
            {

                string labbExampelInput = "29535123p48723487597645723645";

                long sum = 0;
                int lengthOfInput = labbExampelInput.Length;


                for (int i = 0; i < lengthOfInput; i++)
                {

                    string stringBeforeMatch = labbExampelInput.Substring(0, i);
                    for (int j = i + 1; j < lengthOfInput; j++)
                    {

                        string indexMatching = labbExampelInput.Substring(i, j - i + 1);
                        string stringAfterMatch = labbExampelInput.Substring(j + 1);
                        bool isNumber = char.IsDigit(labbExampelInput[j]);

                        if (isNumber == false)
                        {
                            break;
                        }


                        if (labbExampelInput[i] == labbExampelInput[j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(stringBeforeMatch);

                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.Write(indexMatching);
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.Write(stringAfterMatch);

                            long theSum = Convert.ToInt64(indexMatching);
                            sum += theSum;
                            Console.WriteLine();

                            break;
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Summan av alla delsträngar blir: {sum}");
            }
            else if (exampelString == 'n')
            {
                Console.WriteLine("Skriv in din nya sträng: ");
                string newStringInput = Console.ReadLine();


                long sumInNewString = 0;
                int lengthOfInputInNewString = newStringInput.Length;


                for (int i = 0; i < lengthOfInputInNewString; i++)
                {

                    string stringBeforeMatch = newStringInput.Substring(0, i);
                    for (int j = i + 1; j < lengthOfInputInNewString; j++)
                    {

                        string indexMatching = newStringInput.Substring(i, j - i + 1);
                        string stringAfterMatch = newStringInput.Substring(j + 1);
                        bool isNumber = char.IsDigit(newStringInput[j]);

                        if (isNumber == false)
                        {
                            break;
                        }


                        if (newStringInput[i] == newStringInput[j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(stringBeforeMatch);

                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.Write(indexMatching);
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.Write(stringAfterMatch);

                            long theSum = Convert.ToInt64(indexMatching);
                            sumInNewString += theSum;
                            Console.WriteLine();

                            break;
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Summan av alla delsträngar blir: {sumInNewString}");
            }
            else
            {
                Console.WriteLine("Ej ett korrekt input försök igen!");
            }
        }
    }
}