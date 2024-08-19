using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.ApplyF
{
    public static class Operations
    {
        public static double Avg(double[] data)
        {
            double sum = 0.0;
            for (int i = 0; i < data.Length; i++)
                sum += data[i];
            return sum / data.Length;
        }
        public static double Min(double[] data)
        {
            double min = data[0];
            for (int i = 1; i < data.Length; i++)
                if (data[i] < min)
                    min = data[i];
            return min;
        }
        public static double Max(double[] data)
        {
            double max = data[0];
            for (int i = 1; i < data.Length; i++)
                if (data[i] > max)
                    max = data[i];
            return max;
        }

        public static double Sum(double[] data)
        {
            double total = 0;
            for (int i = 0; i < data.Length; i++)
                total += data[i];
            return total;
        }
    }
}
