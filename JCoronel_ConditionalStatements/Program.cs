namespace JCoronel_ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to earn in ISM 4300: ");
            try
            {
                decimal ngrade = Convert.ToDecimal(Console.ReadLine());

                if ((ngrade >= 90) && (ngrade <= 100))
                {
                    Console.WriteLine("Your letter grade is: A");
                }
                else if ((ngrade >= 80) && (ngrade < 90))
                {
                    Console.WriteLine("Your letter grade is: B");
                }
                else if ((ngrade >= 70) && (ngrade < 80))
                {
                    Console.WriteLine("Your letter grade is: C");
                }
                else if ((ngrade >= 60) && (ngrade < 70))
                {
                    Console.WriteLine("Your letter grade is: D");
                }
                else if ((ngrade >= 0) && ((ngrade < 60)))
                {
                    Console.WriteLine("Your letter grade is: F");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a grade greater than or equal to 0, but less than or equal to 100");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a decimal data type for your grade");
            }
            
        }
    }
}
