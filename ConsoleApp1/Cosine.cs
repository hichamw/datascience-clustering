using System;

namespace ConsoleApp1
{
    public class Cosine : IDistance
    {
        public float calculate(int[] x, int[] y)
        {
            var dotProduct = 0.0;
            var leftSum = 0.0;
            var rightSum = 0.0;
            double underside;

            for (int i = 0; i < x.Length; i++)
            {
                dotProduct += x[i] * y[i];
                leftSum += Math.Pow(x[i], 2);
                rightSum += Math.Pow(y[i], 2);
            }

            underside = Math.Sqrt(leftSum) * Math.Sqrt(rightSum);
            
            return (float) (dotProduct / underside);
            //comment
        }
    }
}