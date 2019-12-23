using System;
using static System.Console;

namespace take_home_methods
{
    class Program
    {
        // declare class-level constants
        const double COMMISSION = .07,
                     FEDERAL_TAX_RATE = .18,
                     RETIREMENT_CONTRIB = .15,
                     SOCIAL_SECURITY = .09;
        // declare class-level static variables
        static string employeeName = string.Empty;
        static double employeeSales,
                      employeeCommission,
                      federalTax,
                      retirementContrib,
                      socialSecurity,
                      totalDeductions,
                      takeHomePay;
        static void Main(string[] args)
        {
            Write("Employee Name: ");
            employeeName = ReadLine();
            employeeSales = ReadDouble("Weekly Sales:");
        }
        static double ReadDouble(string label)
        {
            Write("{0} ", label);
            double number;
            string userInput = ReadLine();
            while (Double.TryParse(userInput, out number) == false)
            {
                Write("{0}{1} ", "Invalid input!\n", label);
                userInput = ReadLine();
            }
            return number;
        }
    }
}
