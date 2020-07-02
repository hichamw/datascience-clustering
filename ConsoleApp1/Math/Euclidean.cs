using System;
using NPOI.SS.Formula.Functions;

namespace ConsoleApp1.Math
{
    public class Euclidean : IDistance
    {
        public float Calculate(int[] x, int[] y)
        {
            var pointsSum = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                pointsSum += System.Math.Pow((x[i] - y[i]),2);
            }

            var result = System.Math.Sqrt(pointsSum);
            return (float) result;
        }
        
        public float Calculate(double[] x, double[] y)
        {
            var pointsSum = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                pointsSum += System.Math.Pow((x[i] - y[i]),2);
            }

            var result = System.Math.Sqrt(pointsSum);
            return (float) result;
        }
    }
}