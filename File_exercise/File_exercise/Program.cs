using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "first line", "Second line", "Third line" };
            File.WriteAllLines("FormattedLines.txt", formatlines(lines));

            string[] otherlines = { "another first line", "another Second line", "another Third line" };
            File.WriteAllLines("FormattedLines.txt", formatlines(otherlines));
        }

        static string[] formatlines(string[] unformatedLines)
        {
            string[] formatedLines = new string[unformatedLines.Length];

            for (int i = 0; i < formatedLines.Length; i++)
            {
                formatedLines[i] = String.Format("{0} {1} {2}", "%%%", unformatedLines[i], "%%%");
            }

            return formatedLines;
        }
    }
}
