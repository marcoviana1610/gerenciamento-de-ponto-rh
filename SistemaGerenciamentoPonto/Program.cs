class Program
{
    static void Main()
    {
        EmployeeManage employeeManage = new EmployeeManage();



        //Funcionarios
        employeeManage.AddEmployee(new Employee("144", "Marco Viana"));
        employeeManage.AddEmployee(new Employee("145", "Fulano de Tal"));
        employeeManage.AddEmployee(new Employee("146", "Ciclano de Tal"));
        employeeManage.AddEmployee(new Employee("147", "Beltrano"));
        employeeManage.AddEmployee(new Employee("148", "Joãozinho"));
        employeeManage.AddEmployee(new Employee("149", "Mariazinha"));
        employeeManage.AddEmployee(new Employee("150", "Edinaldo Pereira"));
        //Funcionarios

        
        
        Console.WriteLine("Insira seu código de colaborador: ");
        var employeeCode = Console.ReadLine();


        if (employeeManage.ValidateEmployee(employeeCode))
        {
            var data = DateTime.Now;

            Employee employee = employeeManage.GetEmployeeByCode(employeeCode);
            employeeManage.RecordAttendance(employee);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Colaborador: {employee.Nome}");

            Console.WriteLine();
            Console.WriteLine($"Data de registro: {data.ToString("yyyy-MM-dd")}");

            Console.WriteLine();
            Console.WriteLine($"Horário de registro: {data.ToString("HH:mm:ss")}");

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Código de funcionário inválido.");
        }
    }
}

class Employee
{
    public string Codigo { get; set; }
    public string Nome { get; set; }

    public Employee(string codigo, string nome)
    {
        Codigo = codigo;
        Nome = nome;
    }
}

class EmployeeManage
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public bool ValidateEmployee(string codigo)
    {
        return employees.Exists(x => x.Codigo == codigo);
    }

    public void RecordAttendance(Employee employee)
    {
        //
    }

    public Employee GetEmployeeByCode(string codigo)
    {
        return employees.Find(e => e.Codigo == codigo);
    }
}