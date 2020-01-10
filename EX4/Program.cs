//Novel Poudel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//testing using programmer entered values.
//since the question did not mention about implementing the converter or exception class,
//I have only tested them with two values
namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            //this should throw exception with type TempException
            try
            {
                Console.WriteLine(ConvertTemp.ftoc(-4000000));
            }
            catch(TempException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Some other error has occured - " + e.Message);
            }

            //this should give no errors
            try
            {
                Console.WriteLine(ConvertTemp.ktof(273));
            }
            catch(TempException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some other error has occured - " + e.Message);
            }
        }
    }
}
