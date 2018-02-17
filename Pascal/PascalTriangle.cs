using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pascal
{
    class PascalTriangle
    {
        public void PascalLoop()
        {
            try
            {
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    for (int k = (n - i - 1); k >= 0; k--)
                    {
                        Console.Write(" ");
                    }
                    int num = 1;
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(num);
                        Console.Write(" ");
                        num = num * (i - j) / (j + 1);
                    }

                    Console.WriteLine(" ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
