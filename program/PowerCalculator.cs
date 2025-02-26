using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace program
{
    public class PowerCalculator
    {

        public static int CalculatePower(int basee, int exponent)
        {
            int result = 1;


            if (exponent < 0)
            {
                throw new ArgumentException("A kitevő nem lehet negatív!");
            }


            for (int i = 0; i < exponent; i++)
            {
                result *= basee;
            }

            return result;
        }

        static void Main(string[] args)
        {
            try
            {

                Console.Write("Add meg az első számot: ");
                int basee = int.Parse(Console.ReadLine());

                Console.Write("Add meg a második számot: ");
                int exponent = int.Parse(Console.ReadLine());


                int result = CalculatePower(basee, exponent);


                Console.WriteLine($"Az eredmény: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Hibás bemenet, kérlek egész számokat adj meg.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
            }
        }
    }
}
