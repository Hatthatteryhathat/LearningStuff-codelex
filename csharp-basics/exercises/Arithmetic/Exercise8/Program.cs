using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] employees = new string[3, 3]
            {
                {"Employee 1", "7.5", "35"},
                {"Employee 2", "8.2", "47"},
                {"Employee 3", "10", "73"},
            };

            Console.WriteLine("Name ----- BasePay - HoursWorked - TotalPay");
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                    Console.WriteLine($"{employees[i,0]} || ${employees[i,1]} || {employees[i,2]} ||" +
                        $" {GetTotalPay(employees[i,1], employees[i,2])}");
            }

            Console.ReadKey();
        }

        public static string GetTotalPay(string basePayStr, string hoursWorkedStr) 
        {
            double basePay = Double.Parse(basePayStr);
            double hoursWorked = Double.Parse(hoursWorkedStr);
            double bonusForOvetimeWork = 1.5;

            if (basePay < 8) 
            {
                return "Error: Employee earning below minimum wage!";
            }

            if (hoursWorked > 60) 
            {
                return "Error: Employee working over 60 hours a week!";
            }

            if (hoursWorked > 40) 
            {
                return $"${(basePay * 40) + (basePay * bonusForOvetimeWork) * (hoursWorked - 40)}";
            }

            return $"${basePay * hoursWorked}";
        }
    }
}
