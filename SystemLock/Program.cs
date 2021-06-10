using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SystemLock
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        static void Main(string[] args)
        {
            LockWorkStation();
        }
    }
}
