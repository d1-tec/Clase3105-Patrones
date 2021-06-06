using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;// = new Singleton(); Alternative thread safe 1
        private static object _lock = new object();

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    // ak
                    lock(_lock)
                    {
                        if (_instance == null)
                          _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }

        private Singleton()
        {

        }
    }
}
