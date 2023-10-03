using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlaucoCalcCS.methods
{
    internal class CalcMediana
    {
        public int calcularMediana(int[] array)
        {
            int mediana;

            Array.Sort(array);
            if(array.Length% 2 == 0)
            {
                mediana = (array[array.Length / 2] + array[array.Length / 2 - 1] / 2);
            } else
            {
                mediana = array.Length / 2;
            }

            return mediana;
        }
    }
}
