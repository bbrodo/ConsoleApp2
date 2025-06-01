using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void OperationHandler(string operation, float num1, float num2)
        {
            if (operation == "/")
            {
                Console.WriteLine(num1 / num2);
            } else if (operation == "*")
            {
                Console.WriteLine(num1 * num2);
            } else if (operation == "+") 
            {
                Console.WriteLine(num1 + num2);
            } else if (operation == "-")
            {
                Console.WriteLine(num1 - num2);
            } else
            {
                Console.WriteLine("Error Operator Invalid");
            }
        }
        static void Main(string[] args)
        {

            Console.Write("Enter Operation: (+ - / *) ");
            string operationString = Console.ReadLine();
            Console.Write("Enter First Number:");
            string num1String = Console.ReadLine();
            Console.Write("Enter Second Number:");
            string num2String = Console.ReadLine();
            float num1 = float.Parse(num1String);
            float num2 = float.Parse(num2String);

            OperationHandler(operationString, num1, num2);
            Console.ReadLine();
            Main(args);
        }
    }
}
