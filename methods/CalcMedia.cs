using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlaucoCalcCS.methods
{
    internal class CalcMedia
    {
        public int calcularMedia(int[] array)
        {
            int somaSeq = 0;

            foreach (int i in array)
            {
                somaSeq += i;
            }

            int media = somaSeq / array.Length;

            return media;
        }
    }
}
