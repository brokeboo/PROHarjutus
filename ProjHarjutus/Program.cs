using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjutus
{
    class Harjutus
    {
        public static void Main(string[] args)
        {
            /*int mult = 1;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number: ");
                int smt = Convert.ToInt32(Console.ReadLine());
                sum += smt;
                mult = smt * mult;
            }
            double avg = sum / 5;
            Console.WriteLine($"NUM AVG = {avg}\nNums SUM = {sum}\nNums multiplied = {mult}");
            */


            /*string text;
            do
            {
                Console.WriteLine("buy elephant!");
                Console.Write("Buy: ");

                text = Console.ReadLine();
            } while (text != "elephant");
            Console.WriteLine("Elephant");

            Random rnd = new Random();
            int A = rnd.Next(1, 25);//Arvuti arv
            int AA;//Kasutaja arv
            int K = 1;//Katsed
            do
            {
                Console.WriteLine("{0}. Katse. Mis arv?", K);
                AA = int.Parse(Console.ReadLine());
                K++;
            } while (AA != A || K != 6);
            if (AA == A)
            {
                Console.WriteLine("Palju Õnne");
            }
            else
            {
                Console.WriteLine("Soboleznuju");
            }*/
            int arv;
            int[] arvud = new int[4];
            for (int i=0; i<4; i++)
            {
                Console.WriteLine("Sisesta {0} arv:", i+1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            Array.Sort(arvud);
            foreach (var a in arvud)
            {
                Console.Write(a);
            }
            int arv4 = 0;
            Array.Reverse(arvud);
            foreach(var a in arvud)
            {
                arv4 = arv4 * 10+a;

            }
            Console.Write(arv4);
            Console.ReadLine();
        }
    }
}





