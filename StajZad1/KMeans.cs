using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajZad1
{
    internal class KMeans
    {
        private int k;
        private Random random;

        public KMeans(int k)
        {
            this.k = k;
            this.random = new Random();
        }

        public int[] Cluster(double[][] data)
        {
            int[] labels = new int[data.Length];
            double[][] centroids = InitializeCentroids(data);

            bool changed;
            do
            {
                changed = false;

                for (int i = 0; i < data.Length; i++)
                {
                    int newLabel = GetNearestCentroid(data[i], centroids);
                    if (newLabel != labels[i])
                    {
                        labels[i] = newLabel;
                        changed = true;
                    }
                }

                UpdateCentroids(data, labels, centroids);

            } while (changed);

            return labels;
        }

        private double[][] InitializeCentroids(double[][] data)
        {
            double[][] centroids = new double[k][];
            for (int i = 0; i < k; i++)
            {
                centroids[i] = (double[])data[random.Next(data.Length)].Clone();
            }
            return centroids;
        }

        private int GetNearestCentroid(double[] point, double[][] centroids)
        {
            int nearest = 0;
            double minDist = Distance(point, centroids[0]);

            for (int i = 1; i < centroids.Length; i++)
            {
                double dist = Distance(point, centroids[i]);
                if (dist < minDist)
                {
                    minDist = dist;
                    nearest = i;
                }
            }

            return nearest;
        }

        private void UpdateCentroids(double[][] data, int[] labels, double[][] centroids)
        {
            int[] counts = new int[k];
            for (int i = 0; i < k; i++)
            {
                Array.Clear(centroids[i], 0, centroids[i].Length);
            }

            for (int i = 0; i < data.Length; i++)
            {
                int label = labels[i];
                for (int j = 0; j < data[i].Length; j++)
                {
                    centroids[label][j] += data[i][j];
                }
                counts[label]++;
            }

            for (int i = 0; i < k; i++)
            {
                if (counts[i] == 0) continue;
                for (int j = 0; j < centroids[i].Length; j++)
                {
                    centroids[i][j] /= counts[i];
                }
            }
        }

        private double Distance(double[] point1, double[] point2)
        {
            double sum = 0;
            for (int i = 0; i < point1.Length; i++)
            {
                sum += Math.Pow(point1[i] - point2[i], 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
