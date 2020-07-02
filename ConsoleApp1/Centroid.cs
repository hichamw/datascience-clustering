using System;
using System.Linq;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    public class Centroid
    {
        private int _centroidId;

        private double[] _coordinates;

        private Point[] _points;

        public void Initialize()
        {
            var randomNumber = new RandomNumbers();
            this._coordinates = randomNumber.generateCentroids();
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