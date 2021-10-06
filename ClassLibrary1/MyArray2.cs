using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyArray2
    {
        public void Array()
        {
            Random random1 = new Random();
            int[,] arr = new int[3, 3];

            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = random1.Next(-8, 8);
                }
            }

        }
    }
}
