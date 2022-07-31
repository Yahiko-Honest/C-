using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace Project_test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fileName = @"cikti";

            var doc = DocX.Create(fileName);
            
            doc.InsertParagraph("Hello Word");

            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
