using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22
{
    class Program
    {
        static void Arrey1 ()
        {
            Console.WriteLine("Метод Arrey1 начал работу");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrey = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arrey[i] = random.Next(0, 20);
                Console.WriteLine("{0}", arrey[i]);
            }
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                S += arrey[i];
            }
            Console.WriteLine("Сумма= {0}", S);
            Console.WriteLine("Метод Arrey1 закончил работу");
        }
        static void Arrey2(Task task)
        {
            Console.WriteLine("Метод Arrey2 начал работу");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrey = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arrey[i] = random.Next(0, 20);
                Console.WriteLine("{0}", arrey[i]);
            }
            int max = arrey[0];
            foreach (int a in arrey)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine("Max= {0}", max);
        }
        static void Main(string[] args)
        {
            Action action = new Action(Arrey1);
            Task task1 = new Task (action);

            Action <Task> actionTask = new Action <Task> (Arrey2);
            Task task2 = task1.ContinueWith(actionTask);
           
            task1.Start();
            task1.Wait();
            task2.Wait();
            Console.WriteLine("Main окончил работу");
            Console.ReadKey();


            
        }
       
       
    }
}
