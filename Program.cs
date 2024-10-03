using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowchartTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            string userInput;
            string password;

            do
            {
                Console.WriteLine("adini ve sifre daxil et ");
                userInput = Console.ReadLine();
                password = Console.ReadLine();

                if (userInput == "Yusif" && password == "salam123")
                {
                    Console.WriteLine("ugurli");
                    break;
                }

                else
                {
                    Console.WriteLine("ugursuz");

                }
            }
            while (true);

        }
    }
}
