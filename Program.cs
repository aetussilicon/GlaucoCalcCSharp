using GlaucoCalcCS.methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GlaucoCalcCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sequência");
            String entrada = Console.ReadLine();

            String[] numbers = entrada.Split(',');

            int[] seq = new int[numbers.Length];
            for(int i  = 0; i < numbers.Length; i++)
            {
                seq[i] = int.Parse(numbers[i]);
            }
            
            CalcDp calcDp = new CalcDp();
            CalcMedia calcMedia = new CalcMedia();
            CalcMediana calcMediana = new CalcMediana();

            double desvioPadrao = calcDp.CalcDesviPadrao(seq);
            String desvioPadraoFormatado = desvioPadrao.ToString("F2");
            int media = calcMedia.calcularMedia(seq);
            int mediana = calcMediana.calcularMediana(seq);

            Console.WriteLine($"O desvio padrão é de {desvioPadraoFormatado} \n" +
                $"A media é de {media} \n" +
                $"A mediana é de {mediana}");

            Console.ReadKey();
        }
    }
}
