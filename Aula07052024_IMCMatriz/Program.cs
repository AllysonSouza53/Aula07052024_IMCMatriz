using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07052024_IMCMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] n = new String[5];
            String[] c = new String[5];
            double[] p = new double[5];
            double[] por = new double[5];
            double[] a = new double[5];
            int pe = 0;
            int ac = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome: ");
                n[i] = Console.ReadLine();
                Console.WriteLine("Peso: ");
                p[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Altura: ");
                a[i] = double.Parse(Console.ReadLine());

                double[] IMC = new double[5]; 
                IMC[i] = (a[i] * a[i])/p[i];

                a[i] = a[i] * (10^3);
                Console.WriteLine(a[i]);
                Console.WriteLine(p[i]);
                Console.WriteLine(IMC[i]);
                if (IMC[i] <= 18.5)
                {
                    c[i] = "Abaixo do peso"; 
                }else if (IMC[i] <= 24.9)
                {
                    c[i] = "Peso ideal";                 
                } else if (IMC[i] <= 29.9)
                {
                    c[i] = "Levemente acima do peso";
                    ac++;
                }else if (IMC[i] <= 34.9)
                {
                    c[i] = "Obesidade grau 1";
                    ac++;
                } else if (IMC[i] <= 39.9)
                {
                    c[i] = "Obesidade grau 2";
                    ac++;
                }
                else if (IMC[i] <= 40)
                {
                    c[i] = "Obesidade grau 3";
                    ac++;
                }

                por[i] = 5 * (ac / 100);
            }
            for (int j = 0; j < 5; j++)
            {
                Console.Write("O " + n[j]);
                Console.WriteLine(", esta " + c[j]);
                Console.WriteLine(", porcentagem q esta acima do peso: " + por[j]);
            }
            Console.ReadKey();
        }
            
    }
}
