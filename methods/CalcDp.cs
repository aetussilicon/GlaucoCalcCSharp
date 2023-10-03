using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GlaucoCalcCS.methods
{
    internal class CalcDp
    {
        public double CalcDesviPadrao(int[] array) 
        {
            int[] seqDif = new int[array.Length - 1];

            for(int i = 1; i < array.Length; i++)
            {
                seqDif[i - 1] = array[i] - array[i - 1];
            }

            int[] seqPow = new int[seqDif.Length];

            for (int i = 0; i < seqDif.Length; i++)
            {
                seqPow[i] = (int) Math.Pow(seqDif[i], 2);
            }

            double soma = 0;
            foreach(int n in seqPow)
            {
                soma += n;
            }

            double div = (soma / seqPow.Length);
            double raiz = Math.Sqrt(div);

            return raiz;
        } 
    }
}
