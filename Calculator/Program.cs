namespace calculator
{
    class calculator { 
        public static void Main(string[] args) {
            Console.WriteLine("Enter a first number: ");
            int FNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int SNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Select a desired operation which you want to implent: '+', '-', '*' , '/'");
            char choice = Convert.ToChar(Console.ReadLine());
            int ans; 
            switch (choice)
            {
                case '+':
                    ans = FNumber + SNumber;
                    Console.WriteLine("The addition of {0} and {1} is: {2}", FNumber, SNumber, ans);
                    break;
                case '-':
                    ans = FNumber - SNumber;
                    Console.WriteLine("The subtraction of {0} and {1} is: {2}", FNumber, SNumber, ans);
                    break;
                case '*':
                    ans = FNumber * SNumber;
                    Console.WriteLine("The multiplication of {0} and {1} is: {2}", FNumber, SNumber, ans);
                    break;
                case '/':
                    ans = FNumber / SNumber;
                    Console.WriteLine("The division of {0} and {1} is: {2}", FNumber, SNumber, ans);
                    break;

                default:
                    Console.WriteLine("Operation NOT FOUND!!!!!");
                    break;
            }
        }
    }
}
