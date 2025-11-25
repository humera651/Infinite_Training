// See https://aka.ms/new-console-template for more information
using static Week3_CodingTest.Class1;

IEmployeeDataReader reader = new MockEmployeeDataReader();
PayrollProcessor payroll = new PayrollProcessor(reader);

Console.WriteLine("============= Human Resources application =============\n");

Console.WriteLine("Compensation for 101 : " + payroll.CalculateTotalCompensation(101));
Console.WriteLine("Compensation for 102 : " + payroll.CalculateTotalCompensation(102));
Console.WriteLine("Compensation for 103 : " + payroll.CalculateTotalCompensation(103));
Console.WriteLine("Compensation for 104 : " + payroll.CalculateTotalCompensation(104));

Console.ReadLine();
