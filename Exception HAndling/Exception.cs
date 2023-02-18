using System;
using System.Collections.Generic;
using System.Text;

namespace Encap1
{
    class Encap
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Number");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Number");
                int n2 = int.Parse(Console.ReadLine());

                int z = n1 / n2;

                Console.WriteLine("The Result is" + z);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);

                Console.WriteLine(e.Source);

                Console.WriteLine(e.Message);
                
            }
            catch (FormatException ez)
            {
                Console.WriteLine(ez.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This must Run");
            }
        }
    }
}
