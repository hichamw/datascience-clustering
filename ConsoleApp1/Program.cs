using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
//            var dataLoader = new DataLoader();
//            dataLoader.Load("./WineKMC.xlsx", "./PivotSnippet.csv");

            
            var customerInfo = new CustomerInfo("42069", "Zebi 9lawi","123445");

            Console.WriteLine(customerInfo.CustomerId);
            
//            var cosine = new Cosine();
//            var euclidean = new Euclidean();
//            var randomNumbers = new RandomNumbers();
//            Console.WriteLine(randomNumbers.generateCentroids()[0] +  "|"+randomNumbers.generateCentroids()[0] );
//            Console.WriteLine(euclidean.calculate(new int[] {0, 1}, new int[] {1, 0}));
        }
    }
}