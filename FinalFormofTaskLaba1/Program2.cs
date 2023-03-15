using System;
namespace secondtask
{
    class secondtask1
    {
        public int main()
        {
            int r = 5;
            int[,] Matrix = new int[r, r];
            int[,] Matrix2 = new int[r, r];
            string Martix;
            Console.WriteLine("Fill the matrix:\n");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.WriteLine($"Enter [{i}][{j}] element");
                    Martix = Console.ReadLine();
                    while (!(int.TryParse(Martix, out _)))
                    {
                        Console.WriteLine($"Not a number, try again enter [{i}][{j}] element:\n");
                        Martix = Console.ReadLine();
                    }
                    Matrix[i, j] = int.Parse(Martix);
                    Matrix2[i, j] = int.Parse(Martix);
                }
            }
            int Maxim = 0;
            int Minimal = 0;
            int flag = 0;
            int dontforgetaboutIformax = 0;
            int dontforgetaboutJformax = 0;
            int dontforgetaboutIformin = 0;
            int dontforgetaboutJformin = 0;
            int flag2 = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (j > i)
                    {
                        if (flag == 0)
                        {
                            Maxim = Matrix[i, j];
                            dontforgetaboutIformax = i;
                            dontforgetaboutJformax = j;
                            flag = 1;
                        }
                        else
                        {
                            if (Matrix[i, j] > Maxim)
                            {
                                Maxim = Matrix[i, j];
                                dontforgetaboutIformax = i;
                                dontforgetaboutJformax = j;
                            }
                        }
                    }
                    if (j < i)
                    {
                        if (flag2 == 0)
                        {
                            Minimal = Matrix[i, j];
                            dontforgetaboutIformin = i;
                            dontforgetaboutJformin = j;
                            flag2 = 1;
                        }
                        else
                        {
                            if (Matrix[i, j] < Minimal)
                            {
                                Minimal = Matrix[i, j];
                                dontforgetaboutIformin = i;
                                dontforgetaboutJformin = j;
                            }
                        }
                    }
                }
            }
            Matrix[dontforgetaboutIformax, dontforgetaboutJformax] = Minimal;
            Matrix[dontforgetaboutIformin, dontforgetaboutJformin] = Maxim;
            Console.WriteLine("\n");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(Matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}