using System;
using System.Linq;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    public class Centroid
    {
        private int _centroidId;

        public double[] _coordinates;

        private Point[] _points;

        public void Initialize(int dimensions, Random random)
        {
            _coordinates = new double[dimensions];
            for (int i = 0; i < dimensions; i++)
            {
                this._coordinates[i] = random.NextDouble();
            }
        }

        public void AddPoint(Point p)
        {
            _points.Append(p);
        }

        public void ClearPointList()
        {
            
        }

        public void CalculateCentroidPosition()
        {

        }
    }
}