using System;
using System.Linq;
using System.Runtime.CompilerServices;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataLoader = new DataLoader();
            dataLoader.Load("./WineKMC.xlsx", "./PivotSnippet.csv");

            Console.WriteLine(dataLoader);
            var customerInfo = new CustomerInfo("42069", "Henk Pieterse","123445");

            
            var cosine = new Cosine();
            var euclidean = new Euclidean();
            var randomNumbers = new RandomNumbers();
            
        }
    }
}