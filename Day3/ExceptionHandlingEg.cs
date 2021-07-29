using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
   /// custom or user defined exception in application exception subc;lass
    public class AgeNotValid: ApplicationException
    {
        public AgeNotValid(string Message): base(Message)
        {

        }
    }
    class ExceptionHandlingEg
    {
        static void Main()
        {
            try
            {
                int num = 10, div = 0;
               
                num = num / div;
                Console.WriteLine(num);

                int[] arr = new int[] { 20, 30, 40 };
                Console.WriteLine(arr[6]);
                Console.WriteLine("Enter the age");
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 18)
                {
                    throw new AgeNotValid("To vote, Age should be greater than 18");
                }
                else
                {
                    Console.WriteLine("Eligible to Vote");
                }

            }
           
            /* catch (Exception e) // error: first child then parent
            {
                Console.WriteLine(e);
            }
            */
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e);
               // Console.WriteLine(e.Message);
                //Console.WriteLine(e.Source);
                Console.WriteLine("Please enter valid number!!");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("TRY AGAIN LATER!");
            }

        }
    }
}
