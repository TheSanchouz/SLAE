using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAE
{
    class CramerMethod : SLAEMethod
    {
        public override double[] Solve(double[,] matrix, double[] b)
        {
            int length = matrix.GetLength(0);
            double detMatrix = Determinant(matrix);
            double[] x = new double[length];

            for (int i = 0; i < length; i++)
            {
                double[,] newMatrix = new double[length, length];
                Array.Copy(matrix, newMatrix, length * length);
                for (int j = 0; j < length; j++)
                {
                    newMatrix[j, i] = b[j];
                }

                x[i] = Determinant(newMatrix) / detMatrix;
            }

            Console.WriteLine("Метод Крамера");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"x[{i + 1}] = {x[i]}");
            }

            return x;
        }

        private double Determinant(double[,] matrix)
        {
            int length = matrix.GetLength(0);

            for (int k = 1; k < length; k++)
            {
                for (int i = k; i < length; i++)
                {
                    double coeff = matrix[i, k - 1] / matrix[k - 1, k - 1];

                    for (int j = 0; j < length; j++)
                    {
                        matrix[i, j] -= coeff * matrix[k - 1, j];
                    }
                }
            }


            double det = 1.0;
            for (int i = 0; i < length; i++)
            {
                det *= matrix[i, i];
            }

            return det;
        }
 
        private void swap_row(ref double[,] matrix, int i, int j)
        {
            int length = matrix.GetLength(0);

            for (int k = 0; k < length; k++)
            {
                double temp = matrix[i, k];
                matrix[i, k] = matrix[j, k];
                matrix[j, k] = temp;
            }
        }
    }
}
