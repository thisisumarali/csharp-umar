namespace method_overriding
{
    class Parent { 
        public virtual void show()
        {
            Console.WriteLine("This method is for parent class");
        }
           }
    class Child : Parent
    {
        public override void show()
        {
            Console.WriteLine("This method is for child class");
        }
    }
    class Program { 
        public static void Main()
        {
            Child child = new Child();
            child.show();
        }
    }
}