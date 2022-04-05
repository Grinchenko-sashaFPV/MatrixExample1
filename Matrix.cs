using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalc
{
    class Matrix
    {
        int[,] matrix = new int[3, 3];
        public int this[int index1, int index2]
        {
            get { return matrix[index1, index2]; }
            set { matrix[index1, index2] = value; }
        }
        public void FillMatrix()
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = r.Next(1, 10);
                }
            }
        }
        public void DisplayMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    result[i, j] = m1[i, j] + m2[i, j];
            }
            return result;
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    result[i, j] = m1[i, j] - m2[i, j];
            }
            return result;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    result[i, j] = m1[i, j] * m2[i, j];
            }
            return result;
        }
        private string AllowContinue()
        {
            Console.Write("\n> Продолжить? (y/n) -> ");
            string s = Console.ReadLine();
            return s;
        }
        public void Menu()
        {
                do
                {
                Console.Clear();
                    int ans = 0;
                    Console.WriteLine("1 + ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 * ");
                    Console.Write("Выберите действие: ");
                    ans = Convert.ToInt32(Console.ReadLine());

                    if (ans > 3 || ans < 1)
                        Console.WriteLine("Запрос неверный!");
                    else
                    {
                        switch (ans)
                        {
                            case 1:
                                {
                                    Matrix m1 = new Matrix();
                                    m1.FillMatrix();
                                    m1.DisplayMatrix();
                                    Console.WriteLine("\n +");
                                    Matrix m2 = new Matrix();
                                    m2.FillMatrix();
                                    m2.DisplayMatrix();
                                    Console.WriteLine("\n =");
                                    Matrix m3 = m1 + m2;
                                    m3.DisplayMatrix();
                                    break;
                                }
                            case 2:
                                {
                                    Matrix m1 = new Matrix();
                                    m1.FillMatrix();
                                    m1.DisplayMatrix();
                                    Console.WriteLine("\n -");
                                    Matrix m2 = new Matrix();
                                    m2.FillMatrix();
                                    m2.DisplayMatrix();
                                    Console.WriteLine("\n =");
                                    Matrix m3 = m1 - m2;
                                    m3.DisplayMatrix();
                                    break;
                                }
                            case 3:
                                {
                                    Matrix m1 = new Matrix();
                                    m1.FillMatrix();
                                    m1.DisplayMatrix();
                                    Console.WriteLine("\n *");
                                    Matrix m2 = new Matrix();
                                    m2.FillMatrix();
                                    m2.DisplayMatrix();
                                    Console.WriteLine("\n =");
                                    Matrix m3 = m1 * m2;
                                    m3.DisplayMatrix();
                                    break;
                                }
                        }
                    }
                } while (AllowContinue() == "y");
            }
    }
}
