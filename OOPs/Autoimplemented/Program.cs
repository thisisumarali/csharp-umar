namespace autoimplemented
{
    class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public void SetStudentDetails(int id, string
name, string desc)
        {
            this.Id = id;
            this.Name = name;
            this.Description = desc;
        }
        public void GetStudentDetails()
        {
            Console.WriteLine(this.Id);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Description);
        }
    }

    class Program { 
        public static void Main()
        {
            Student s = new Student();
            Console.WriteLine("Enter Student ID:"); 
            int Id=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Description:");
            string desc = Console.ReadLine();

            s.SetStudentDetails(Id, name, desc);
            s.GetStudentDetails();
        }
    }
}
