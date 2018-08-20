using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_2
{
    public class AgeExceptions : Exception
    {
        public AgeExceptions() : base() { }
        public AgeExceptions(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string input = Console.ReadLine();
            int yearBorn = DateTime.Now.Year;
            const string errorMsg = "Invalid age - age must be greater than zero...and this program refuses to believe you're over 100";
            try
            {
                int age = Convert.ToInt32(input);
                if (age <= 0 || age >= 100)
                {
                    throw new AgeExceptions();
                }
            }
            catch (AgeExceptions)
            {
                Console.WriteLine(errorMsg);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid age input");
            }
            
                    
        }
    }
}
