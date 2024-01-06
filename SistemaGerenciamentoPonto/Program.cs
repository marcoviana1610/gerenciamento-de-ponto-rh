using SistemaGerenciamentoPonto;
using System.Media;

class Program
{
    static void Main()
    {
        EmployeeManage employeeManage = new EmployeeManage();



        //Funcionarios
        employeeManage.AddEmployee(new Employee("144", "Marco Viana"));
        employeeManage.AddEmployee(new Employee("145", "Fulano"));
        employeeManage.AddEmployee(new Employee("146", "Ciclano"));
        employeeManage.AddEmployee(new Employee("147", "Beltrano"));
        employeeManage.AddEmployee(new Employee("148", "Joãozinho"));
        employeeManage.AddEmployee(new Employee("149", "Mariazinha"));
        employeeManage.AddEmployee(new Employee("150", "Edinaldo Pereira"));
        //Funcionarios

        
        
        Console.WriteLine("Insira seu código de colaborador: ");
        var employeeCode = Console.ReadLine();
        Console.WriteLine();


        if (employeeManage.ValidateEmployee(employeeCode))
        {
            var data = DateTime.Now;

            Employee employee = employeeManage.GetEmployeeByCode(employeeCode);
            employeeManage.RecordAttendance(employee);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Ponto registrado com sucesso!");
            Console.WriteLine();

            

            Console.WriteLine($"Colaborador: {employee.Nome}");

            Console.WriteLine($"Data: {data.ToString("yyyy-MM-dd")}");

            Console.WriteLine($"Horário: {data.ToString("HH:mm:ss")}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para um novo registro");
            Console.ReadKey();

            Console.Clear();
            Main();

        }
        else
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Beep();
            Console.Beep();
            Console.WriteLine("Algo deu errado. Por favor, insira um código válido");

            Main();
        }
    }
}