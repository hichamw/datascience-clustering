
namespace ConsoleApp1.Math
{
    public class Cosine : IDistance
    {
        public float Calculate(int[] x, int[] y)
        {
            var dotProduct = 0.0;
            var leftSum = 0.0;
            var rightSum = 0.0;
            double underside;

            for (int i = 0; i < x.Length; i++)
            {
                dotProduct += x[i] * y[i];
                leftSum += System.Math.Pow(x[i], 2);
                rightSum += System.Math.Pow(y[i], 2);
            }

            underside = System.Math.Sqrt(leftSum) * System.Math.Sqrt(rightSum);
            
            return (float) (dotProduct / underside);
        }
        
        public float Calculate(double[] x, double[] y)
        {
            var dotProduct = 0.0;
            var leftSum = 0.0;
            var rightSum = 0.0;
            double underside;

            for (int i = 0; i < x.Length; i++)
            {
                dotProduct += x[i] * y[i];
                leftSum += System.Math.Pow(x[i], 2);
                rightSum += System.Math.Pow(y[i], 2);
            }

            underside = System.Math.Sqrt(leftSum) * System.Math.Sqrt(rightSum);
            
            return (float) (dotProduct / underside);
        }
    }
}