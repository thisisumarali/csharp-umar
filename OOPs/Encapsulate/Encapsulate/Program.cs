namespace encapsulate
{
    class Student {
        private string SName;
        private int SAge;


        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name)== true)
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                this.SName = Name;
            }
        }
     
        public void GetName()
        {
            if(string.IsNullOrEmpty(this.SName)== true)
            {
                

        }
            else
            {
                Console.WriteLine("Your Name is: {0}", this.SName);
            }
        }
        public void SetAge(int Age)
        {
            if (Age <=0)
            {
                Console.WriteLine("Age is not correct");
                return;
            }
            else if(Age >= 117){
                Console.WriteLine("You are fraud person");
            }
            else
            {
                this.SAge = Age;
            }
        }
        public void GetAge()
        {
            if (!(this.SAge == 0))
            {
                Console.WriteLine("Your Age is: {0}", this.SAge);
            }

         
        }
    }
       class Program { 
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.SetName("Umar");
            s.GetName();
            s.SetAge(120);
            s.GetAge();
        }
    }
   }
