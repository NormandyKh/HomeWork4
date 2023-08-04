namespace HomeWork4.Employee
{
    internal class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public void IncreaseSalary(double amount)
        {
            salary += amount;
        }

        public void DecreaseSalary(double amount)
        {
            if (salary - amount >= 0)
            {
                salary -= amount;
            }
            else
            {
                Console.WriteLine("Зарплата не может быть меньше 0.");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Employee other = (Employee)obj;
            return name == other.name && salary == other.salary;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Equals(emp2);
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !emp1.Equals(emp2);
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.salary < emp2.salary;
        }

        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.salary > emp2.salary;
        }

        public static Employee operator +(Employee emp, double amount)
        {
            emp.salary += amount;
            return emp;
        }

        public static Employee operator -(Employee emp, double amount)
        {
            if (emp.salary - amount >= 0)
            {
                emp.salary -= amount;
            }
            else
            {
                Console.WriteLine("Зарплата не может быть меньше 0.");
            }
            return emp;
        }

    }
}
