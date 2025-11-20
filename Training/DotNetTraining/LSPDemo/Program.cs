using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            EmployeeBase emp1 = new PermanentEmployee();
            EmployeeBase emp2 = new ContractEmployee();

            Console.WriteLine("---------LSP Demo---------");

            program.CheckBonus(emp1);
            program.CheckBonus(emp2);

            Console.ReadLine();
        }
        public void CheckBonus(EmployeeBase emp)
        {
            if (emp is IBonusEligible bonusEmp)
            {
                Console.WriteLine("Bonus: " + bonusEmp.GetBonus(20000));
            }
            else
            {
                Console.WriteLine("No bonus available");
            }
        }
    }
}
