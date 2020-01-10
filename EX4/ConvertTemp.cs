using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    //converter class without any variables
    //all the functions are static
    class ConvertTemp
    {
        public static double ftoc(double f)
        {
            double c = (f - 32) / 1.8;
            if (c < -273.15)
                throw new TempException("Cannot provide an output. Temperature is below absolute 0");
            return c;
        }

        public static double ctof(double c)
        {
            if (c < -273.15)
                throw new TempException("Cannot provide an output. Temperature is below absolute 0");
            double f = c * 1.8 + 32;
            return f;
        }

        public static double ftok(double f)
        {
            double k = ((f - 32) / 1.8) + 273.15;
            if (k < 0)
                throw new TempException("Cannot provide an output. Temperature is below absolute 0");
            return k;
        }

        public static double ktof(double k)
        {
            if (k < 0)
                throw new TempException("Cannot provide an output. Temperature is below absolute 0");
            double f = (k - 273.15) * 1.8 + 32;
            return f;
        }

        public static double ktoc(double k)
        {
            if (k < 0)
                throw new TempException("Cannot provide an output. Temperature is below absolute 0");
            double c = k - 273.15;
            return c;
        }

        public static double ctok(double c)
        {
            if(c<-273.15)
                throw new TempException("Cannot provide an output. Temperature is below absolute 0");
            double k = c + 273.15;
            return k;
        }
    }
}
