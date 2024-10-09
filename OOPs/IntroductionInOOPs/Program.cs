namespace Program {
    class Employee
    {
        string name;
        int age;
        string department;

        void employee_details() {
            Console.WriteLine("Here is the information of this employee");
        }
        public static void Main()
        {
            Employee e1 = new Employee();
            e1.name = "Abdul Habib";
            e1.age = 23;
            e1.department = "Networking";
            e1.employee_details();
        
            Console.WriteLine(e1.name);
            Console.WriteLine(e1.age);
            Console.WriteLine(e1.department);
            Employee e2 = new Employee();
            e2.name = "Ali";
            e2.age = 20;
            e2.department = "Computer Science";
            e2.employee_details();
            Console.WriteLine(e2.name);
            Console.WriteLine(e2.age);
            Console.WriteLine(e2.department);

        } 

    }
}
