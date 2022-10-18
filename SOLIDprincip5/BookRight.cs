using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprincip5
{
    interface IPrinter
    {
        void PrintRight(string text);
    }

    class BookRight
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }

        public BookRight(IPrinter printer)
        {
            this.Printer = printer;
        }

        public void Print()
        {
            Printer.PrintRight(Text);
        }
    }

    class ConsolePrinterRight : IPrinter
    {
        public void PrintRight(string text)
        {
            Console.WriteLine("Печать на консоли");
        }
    }

    class HtmlPrinter : IPrinter
    {
        public void PrintRight(string text)
        {
            Console.WriteLine("Печать в html");
        }
    }
}
