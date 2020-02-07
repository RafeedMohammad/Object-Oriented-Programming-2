using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.com.singleton
{
    class Logger
    {
        private static Logger logger;
        private Logger()   //private: no other classes can't create any object of the class Logger!
        {

        }

        public static Logger GetInstance()
        {
            if(logger == null)
            {
                logger = new Logger();
            }

            return logger;

        }
    }
}
