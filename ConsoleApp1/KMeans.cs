using System;
using System.IO;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    public class KMeans
    {
        public Centroid[] Centroids;
        public Point[] Points;
        public readonly Random Random = new Random();

        public void ComparePoints()
        {
            Euclidean euclidean = new Euclidean();
            var res = euclidean.Calculate(Points[1].CustomerSalesInfo, Points[2].CustomerSalesInfo);
            for (int i = 0; i < Points[1].CustomerSalesInfo.Length; i++)
            {
                Console.WriteLine(Points[1].CustomerSalesInfo[i]+",");
            }
            Console.WriteLine("Euclidean: "+ res);
        }

        public void InitializeCentroids(int k, int dimensions)
        {
            Centroids = new Centroid[k];
            for (int i = 0; i < k; i++)
            {
                var centroid = new Centroid();
                centroid.Initialize(dimensions, Random);
                Centroids[i] = centroid;
            }
        }

        public void InitializePoints(string pivotSnippetPath, int dimensions)
        {
            var points = new Point[102];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
                points[i].CustomerSalesInfo = new int[dimensions];
            }

            int count = -1;
            using (var reader = new StreamReader(pivotSnippetPath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    for (int i = 0; i < values.Length; i++)
                    {
                        int temp;
                        if (int.TryParse(values[i], out temp))
                        {
                            points[i].CustomerSalesInfo[count] = int.Parse(values[i]);
                        }
                    }

                    count++;
                }
            }

            Points = points;
        }
    }
}