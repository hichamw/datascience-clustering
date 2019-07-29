using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
//            var dataLoader = new DataLoader();
//            dataLoader.LoadPivot();
            
            var cosine = new Cosine();
            Console.WriteLine(cosine.calculate(new int[] {0, 1, 1, 0}, new int[]{1, 0, 1, 1}));
            
        }
    }
}