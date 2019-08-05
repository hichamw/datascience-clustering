using System;

namespace ConsoleApp1
{
    public class Centroid
    {
        private int centroidId;

        private double[] coordinates;

        public Centroid(int centroidId, double[] coordinates)
        {
            this.centroidId = centroidId;
            this.coordinates = coordinates;
        }

        public void Initialize()
        {
            Random random = new Random();

            coordinates[0] = random.NextDouble() + 1;
            coordinates[1] = random.NextDouble() + 1;

        }

        public void AddPoint(Point p)
        {

        }

        public void ClearPointList()
        {

        }

        public void CalculateCentroidPosition()
        {

        }
    }
}