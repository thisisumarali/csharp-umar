namespace abstraction
{
      class Employee {
        private int emp_id;
        private string emp_name;
        private double tax_deduction = 0.1;
        private double grosspay;
        private double netsalary;


        public Employee(int id, string name, double grosspay)
        {
            this.emp_id = id;
            this.emp_name = name;
            this.grosspay = grosspay;
        }
        void CalculateSalary()
        {
             if (this.grosspay >= 50000) {
                this.netsalary = this.grosspay - (this.tax_deduction * this.grosspay);
                Console.WriteLine("Employe Salary is: {0}", this.netsalary);
                            }
             else
            {
                Console.WriteLine("Employe Salary is: {0}", this.grosspay);
            }
        }
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Employee ID: {0}", this.emp_id);
            Console.WriteLine("Employee Name: {0}", this.emp_name);
            this.CalculateSalary();
        }

    }
        class Program { 
        public static void Main()
        {
            Console.WriteLine("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            double grosspay = double.Parse(Console.ReadLine());
            Employee ahsan = new Employee(id, name, grosspay);
            ahsan.GetEmployeeDetails();
        }
    }

}