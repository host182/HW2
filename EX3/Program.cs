using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio newRadio = new Radio();
            do
            {
                Console.WriteLine("The radio is turned off. Do you want to turn it on?\n\t1. Switch it on\t\t2. Do nothing\nEnter 1 or 2");
                string input = Console.ReadLine();
                if(input == "1")
                {
                    do
                    {
                        //menu
                        Console.WriteLine("Welcome to your radio\nWhat do you want to do?\n\t1. Change channel\n\t2. Change Volume\n\t0. Turn the radio off");
                        string option = Console.ReadLine();
                        if(option == "1")
                        {
                            Console.WriteLine("Enter a value to tune the channel to");
                            re:
                            string channelString = Console.ReadLine();
                            double channel;
                            //a negative number throws an error
                            try
                            {
                                channel = Convert.ToDouble(channelString);
                            }
                            catch
                            {
                                Console.WriteLine("Enter a positive number");
                                //if error is thrown, enter the number again
                                goto re;
                            }
                            newRadio.tune(channel);
                        }
                        else if(option == "2")
                        {
                            Console.WriteLine("Enter an integer to change volume by.(If you want to reduce the volume, enter a negative integer)");
                            re1:
                            string volString = Console.ReadLine();
                            int vol;
                            //even a decimal number throws an error
                            try
                            {
                                vol = int.Parse(volString);
                            }
                            catch
                            {
                                Console.WriteLine("Enter an integer");
                                goto re1;
                            }
                            newRadio.changeVolumeBy(vol);
                        }
                        else if(option =="0")
                        {
                            Console.WriteLine("Radio is now turned off");
                            break;
                        }
                    }while(true);
                }
                //even when user enters a string that is not 2, the program considers it an exit code
                else
                    break;
            }while(true);
        }
    }
}
