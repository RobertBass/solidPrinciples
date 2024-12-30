namespace OpenClose
{
    public class EmployeeContractor: Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal calculateSalary()
        {
            decimal hourValue = 25000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }

    }
}