namespace constructor_in_sharp
{
    class Employees
    {
        public Employees() // with no parameter 
        {
            Console.WriteLine("Constructor Invokes...");
        }
        // Default constructor Or special methods which is directly called with object initialiazation
        // construct Overloading
        public Employees(string name)
        {
            Console.WriteLine($"Name: {name}");
        }
        public Employees(string name,string pnum)
        {
            Console.WriteLine($"Name: {name}, Contact: {pnum}");
        }
        // Entry Point 
        public static void Main(string[] args)
        {
            Employees invoking = new Employees();
            Employees Nasir = new Employees("Nasir");
            Employees Mubashir = new Employees("Mubashir", "0311-0205781");
        }
    }

}
