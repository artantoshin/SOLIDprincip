using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SOLIDprincip
{
    internal class PrintRight
    {
        public void Print()
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(Text);
        }
    }
}
