namespace Loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = 1;

 //         while (numb < 10)
 //         {
 //             Console.WriteLine(numb);
 //             numb++;
 //         }
 //
 //         do
 //         {
 //             Console.WriteLine("hej");
 //         } while (false);
 //
         for (int k = 1; k <= 3; k++)
            {
              for (int j = 1; j <= 4; j++)
              {
                 for (int i = 1; i < 10; i++)
                 {
                 Console.Write(i);
                 }
                  Console.WriteLine();
              }
                Console.WriteLine("----------");
            }
    }

    }
}