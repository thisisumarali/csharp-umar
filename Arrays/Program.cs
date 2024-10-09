namespace AccessArray {
    class Arrays
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3]; // Setting A Rule Or fixed length
            arr[0] = 5;
            arr[1] = 6;
            arr[2] = 7;


            string[] student_Name = { "Mazhar", "Azhar", "Salman" }; // Non Generic Collection

            // Forcefully
            dynamic[] employe_Name = { "Khalid", "Muaz", "Muneeb", 12.12F, "Naseem" };

            for(int i=0;i<arr.Length; i++) {
                Console.WriteLine("the value at {0} is {1}", i, arr[i]);
            }

            // Array functions 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            Console.WriteLine("The minimum number of this array is: " + numbers.Min());
            Console.WriteLine("The maximum number of this array is: " + numbers.Max());
            Console.WriteLine("The total number of this array is: " + numbers.Count());
        }
    }
}