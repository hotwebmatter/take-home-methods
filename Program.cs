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
            WriteLine("Hello World!");
        }
    }
}
