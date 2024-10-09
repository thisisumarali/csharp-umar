namespace method_overloading
{
    class Addition { 
    public void Add()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            Console.WriteLine(c);
        }
    public void Add(int a , int b)
        {
            int c = a + b;
        Console.WriteLine(c);
        }    
      public void Add(float a , float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        } 
        public void Add(string a , string b)
        {
            string c = a + b;
            Console.WriteLine(c);
        }
    }
    class Program { 
        public static void Main(string[] args)
        {
            Addition add = new Addition();
            add.Add(1, 2);
            add.Add("5", "4");
        }
    }
}
