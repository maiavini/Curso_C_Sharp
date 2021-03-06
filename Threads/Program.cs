using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Thread_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
            t.Start(); 
            t.Join();//Executa primeiramente essa Thread até o fim.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
                Thread.Sleep(500);// Define em milisegundos o tempo de intervalo da tarefa
            }

            Console.ReadKey();
        }


        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada");
                Thread.Sleep(1500);
            }
        }
    }
}
