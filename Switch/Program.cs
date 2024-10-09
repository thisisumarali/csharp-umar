namespace switch_case
{
    class switch_case { 
        public static void Main(string[] args)
        {
            /*  char ch;
              Console.WriteLine("Enter  a character");
              ch = Convert.ToChar(Console.ReadLine());
              switch (Char.ToLower(ch))
              {
                  case 'a':
                      Console.WriteLine("Vowel");
                      break;
                  case 'b':
                      Console.WriteLine("Vowel");
                      break;
                  case 'c':
                      Console.WriteLine("Vowel");
                      break;
                  case 'd':
                      Console.WriteLine("Vowel");
                      break;
                  case 'e':
                      Console.WriteLine("Vowel");
                      break;
                  default: Console.WriteLine("Not a vowel");
                      break;
              }
            */
            Console.WriteLine("Enter a First Number");
            int FNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Second Number");
            int SNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Third Number");
            int TNumber = int.Parse(Console.ReadLine());

            int largestNumber;

            if (FNumber >= SNumber && FNumber >= TNumber)
            {
                largestNumber = FNumber;
            }
            else if (SNumber >= FNumber && SNumber >= TNumber)
            {
                largestNumber = SNumber;
            }
            else
            {
                largestNumber = TNumber;
            }

            Console.WriteLine("The Largest Number Is: " + largestNumber);

        }

    }
}
