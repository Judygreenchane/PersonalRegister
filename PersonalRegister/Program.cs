using System;
using System.Collections;


namespace PersonalRegister
{
    class Program
    {

        static bool programQuit = false;
        static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            while (programQuit == false)
            {
                MainMenuText();
                UserChoise(UserInput());
            }
        }

        static void MainMenuText()
        {
            Console.WriteLine("Gör ditt val");
            Console.WriteLine("1 : Ange personal uppgifter");
            Console.WriteLine("2 : Visa personal uppgifter");
            Console.WriteLine("3 : Avslutta program");
        }
        static int UserInput()
        {
            string inputString = Console.ReadLine();
            int inputNum;
            Int32.TryParse(inputString, out inputNum);
            return inputNum;
        }
        static void UserChoise(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    AngePersonalUppgifter();
                    break;
                case 2:
                    VisaPersonalUppgifter();
                    break;
                case 3:
                    Console.WriteLine("Programmet Avsluttas");
                    programQuit = true;
                    break;
                default:
                    Console.WriteLine("Ditt val är ej giltigt , prova igen. ");
                    UserChoise(UserInput());
                    break;




            }
        }
        static void AngePersonalUppgifter()
        {
            Console.WriteLine("Ange Personals Namn");
            string name = Console.ReadLine();
            Console.WriteLine("Ange Personals lön");
            int salary = Int32.Parse(Console.ReadLine());
            payroll.AddEmployees(name, salary);
        }
        static void VisaPersonalUppgifter()
        {
            IEnumerable<Employee> emp = payroll.GetEmployees();
            foreach (Employee employee in emp)
            {
                Console.WriteLine($"Name  : {employee.Name}    Salary    : {employee.Salary}");
            }


        }

    }
}
