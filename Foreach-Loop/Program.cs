namespace foreach_genders
{
    class countGendersProgram
    {
        public static void Main(string[] args)
        {
            char[] genders = { 'M', 'F', 'M', 'F', 'M' };

            int male = 0; int female = 0;
            foreach (char c in genders)
            {
                if (c == 'M')
                {
                    male++;
                }
                else
                {
                    female++;
                }
                       }
            Console.WriteLine("Total No of males: " + male);
            Console.WriteLine("Total No of female: " + female);
        }
    }
}