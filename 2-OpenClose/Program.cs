using OpenClose;

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Jose Pihuave", 200)
});


void CalculateSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, pago: {employee.calculateSalary():C1}");
    }

}