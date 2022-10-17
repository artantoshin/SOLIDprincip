using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprincip
{
    internal class ReportRight
    {
        public string Text { get; set; } = "";
        public void GoToFirstPage() =>
            Console.WriteLine("Переход к первой странице");

        public void GoToLastPage() =>
            Console.WriteLine("Переход к последней странице");

        public void GoToPage(int pageNumber) =>
            Console.WriteLine($"Переход к странице {pageNumber}");
    }
}
