using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowchartTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            //int number = 126;

            //int firstDigit = number / 100;
            //int secondDigit = (number / 10) % 10;
            //int thirdDigit = number % 10;

            //int sum = firstDigit + secondDigit + thirdDigit;

            //if (sum % 2 == 0)
            //{
            //    Console.WriteLine("Reqemlerin cemi cütdür");
            //}
            //else
            //{
            //    Console.WriteLine("Reqemlerin cemi tekdir");
            //}




            //TASK 2
            //int number = 1234;

            //int firstDigit = number / 1000;
            //int secondDigit = (number / 100) % 10;
            //int thirdDigit = (number / 10) % 10;
            //int fourthDigit = number % 10;

            //int average = (firstDigit + secondDigit + thirdDigit + fourthDigit) / 4;
            //Console.WriteLine(average);




            // TASK 3
            //int number = 150;

            //int firstDigit = number / 100;
            //int secondDigit = (number / 10) % 10;
            //int thirdDigit = number % 10;

            //int sumOfDigits = firstDigit + secondDigit + thirdDigit;


            //if (sumOfDigits % 3 == 0 && sumOfDigits % 5 == 0)
            //{
            //    Console.WriteLine("bu ededin reqemlerinin cemi 3 ve 5 tam bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("bu ededin reqemlerinin cemi 3 ve 5 tam bolunmur");
            //}



            //TASK 4
            //float gpa = 88.8f;
            //switch (gpa) {
            //    case float n when (n > 50f && n < 61f):
            //        Console.WriteLine("E");
            //        break;
            //    case float n when (n > 60f && n < 71f):
            //        Console.WriteLine("D");
            //        break;
            //    case float n when (n > 70f && n < 81f):
            //        Console.WriteLine("C");
            //        break;
            //    case float n when (n > 80f && n < 91f):
            //        Console.WriteLine("B");
            //        break;
            //    case float n when (n > 90f && n <= 100f):
            //        Console.WriteLine("A");
            //        break;
            //        default:
            //        Console.WriteLine("You are disqualified");
            //        break;
            //}





            //TASK 5
            //int number1 = 30;
            //int number2 = 20;
            //int sum;
            //int difference;

            //if (number1 % 2 == 0 && number2 % 2 == 0)
            //{
            //    sum = number1 + number2;
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    difference = number1 - number2;
            //    Console.WriteLine(difference);
            //}




            // TASK 6
            int salary = 5000;
            int loanAmount = 10000;
            int annualIncome = salary * 12;
            float maxLoanAmount = annualIncome * 0.60f;

            if (loanAmount > maxLoanAmount)
            {
                Console.WriteLine("It was unsuccessful");
            }
            else
            {
                Console.WriteLine("It was successful");
            }







        }
    }
}
