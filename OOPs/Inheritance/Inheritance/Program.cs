namespace Inheritance {
   public class Employee
    {
        int EmpId;
        public string EmpName;
        public string EmpContact;
        public int EmpAge;
    }
    public class PermanentEmployee : Employee {
        public double PermanentSalary;
        public double PermanentAge;
        public bool PermanentEmploye;
    }
      public class VisitingEmployee : Employee {
        public double VisitingSalary;
        public double VisitingHours;
    }
    class Testing
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
         //   e1.EmpId = 1;
            e1.EmpName = "Abdur Rehman";
            e1.EmpAge = 21;

            PermanentEmployee p1 = new PermanentEmployee();
           // p1.EmpId = 2;
            p1.EmpName = "Abdul Raheem";
            p1.PermanentEmploye = true;
            p1.PermanentSalary = 2000000;
            Console.WriteLine($"Employe Id:{e1.EmpId}\nEmploye Name:{e1.EmpName}\nEmploye Age: {e1.EmpAge}");
            Console.WriteLine($"Employe Id:{p1.EmpId}\nEmploye Name:{p1.EmpName} \nEmploye Age: {p1.PermanentSalary}\nPermanent Employe? {p1.PermanentEmploye}" );
        } 
    }
}
