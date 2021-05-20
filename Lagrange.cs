using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POK_ZAD5
{

    public static class Lagrange
    {

        public static double Interpolate(List<Data> f, int xi, int n)
        {
            double result = 0; // Initialize result

            for (int i = 0; i < n; i++)
            {
                // Compute individual terms
                // of above formula
                double term = f[i].y;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                        term = term * (xi - f[j].x) /
                                  (f[i].x - f[j].x);
                }

                // Add current term to result
                result += term;
            }
            return result;
        }


        public static double[] InterpolateAll(List<Data> f, int numberOfxi, int n)
        {
            double[] result = new double[numberOfxi]; // Initialize result
            for (int a = 1; a < numberOfxi; a++)
            {
                result[a] = 0;
                for (int i = 0; i < n; i++)
                {
                    // Compute individual terms
                    // of above formula
                    double term = f[i].y;
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            term = term * (a - f[j].x) /
                                      (f[i].x - f[j].x);
                    }

                    // Add current term to result
                    result[a] += term;
                }
            }
            return result;
        }
    }
}
