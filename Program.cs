using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtraUtilities;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers(5);

            double[] exampleList = { 1, 2, 3};
            XtraUtilities.List<double> list = new XtraUtilities.List<double>(exampleList);

            Equations equ = new Equations();
            

            list.PrintList();

            list.Reverse();
            list.PrintList();

            Console.WriteLine(list.ListTot());

            list.AddToIndexes(3, 1, 2);
            list.PrintList();

            list.SubToIndexes(4, 0, 2);
            list.PrintList();

            list.MulToIndexes(45, 2, 2);
            list.PrintList();

            list.DivToIndexes(3, 1, 2);
            list.PrintList();

            list.PowIndexes(2, 0, 1);
            list.PrintList();

            list.Push(64);
            list.PrintList();

            list.Pop();
            list.PrintList();

            list.Insert(55, 1);
            list.PrintList();

            list.Remove(3);
            list.PrintList();

            list.Reset();
            list.PrintList();

            list.FillWith(7);
            list.PrintList();

            list.Extend(2);
            list.PrintList();

            list.ExtendWith(3, 8);
            list.PrintList();

            list.ResetToDim(1);
            list.PrintList();

            list.ResetAndFill(4, 7);
            list.PrintList();

            int[] liste = list.Find(7);

            for(int i = 0; i < liste.Length; i++)
            {
                Console.Write(liste[i]);
            }



            Console.ReadKey();
        }
    }
}
