using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    interface ITunable    
    {
        void tune(double c);
    }

    interface ITogglable
    {
        void toggle();
    }

    interface IVolumizer
    {
        void changeVolumeBy(int v);
    }


    class Radio : ITogglable, ITunable, IVolumizer
    {
        bool power;
        double channel;
        int volume;

        public Radio(bool p = false, double c = 0, int v = 0)
        {
            power = p; channel = c; volume = v;
        }

        public void toggle()
        {
            power = !power;
            if(power)
                Console.WriteLine("Radio is turned on");
            else
                Console.WriteLine("Radio is turned off");
        }

        public void tune(double c)
        {
            if(c<0)
                throw new ApplicationException("Channel cannot be negative");
            channel = c;
            Console.WriteLine("Radio tuned at "+channel);
        }

        public void changeVolumeBy(int v)
        {
            if(volume + v < 0)
            {
                volume = 0;
                throw new ApplicationException("volume cannot be tuned to less than 0");
                Console.WriteLine("The volume is now " + volume);
            }
            volume += v;
            Console.WriteLine("The volume is now " + volume);
        }
    }
}
