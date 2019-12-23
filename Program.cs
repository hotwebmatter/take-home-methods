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
            CalculateResults();
            WriteLine(DisplayResults());
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
        static void CalculateResults()
        {
            employeeCommission = employeeSales * COMMISSION;
            federalTax = employeeCommission * FEDERAL_TAX_RATE;
            retirementContrib = employeeCommission * RETIREMENT_CONTRIB;
            socialSecurity = employeeCommission * SOCIAL_SECURITY;
            totalDeductions = federalTax + retirementContrib + socialSecurity;
            takeHomePay = employeeCommission - totalDeductions;
        }
        static string DisplayResults()
        {
            string result = String.Format("\n****** Take-Home Pay Calculator ******\n");
            result += String.Format("* {0, 18}{1, 16} *\n", "Employee Name:", employeeName);
            result += String.Format("* {0, 18}{1, 16:C} *\n", "Weekly Sales:", employeeSales);
            result += String.Format("* {0, 18}{1, 16:C} *\n", "Commission:", employeeCommission);
            result += String.Format("* {0, 18}{1, 16:C} *\n", "Federal Tax:", federalTax);
            result += String.Format("* {0, 18}{1, 16:C} *\n", "Retirement:", retirementContrib);
            result += String.Format("* {0, 18}{1, 16:C} *\n", "Social Security:", socialSecurity);
            result += String.Format("* {0, 18}{1, 16:C} *\n", "Total Deductions:", totalDeductions);
            result += String.Format("* {0, 18}{1, 16:C} *\n", "Take-Home Pay:", takeHomePay);
            result += String.Format("**************************************\n");
            return result;
        }
    }
}
