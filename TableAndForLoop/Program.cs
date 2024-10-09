namespace Table_Program; 
class Table_Program
{
    public static void Main(String[] args) {
        /* Console.WriteLine("Enter a number to get the table of your choice: ");
         int num = int.Parse(Console.ReadLine());

         for(int i = 1; i <= 10; i++) {
             Console.WriteLine(num + " * " + i + " = " + num * i);
         }
        */
        int num = 10; 
        for(int i=1;i<=num; i++)
        {
            for(int j=1;j<=i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
