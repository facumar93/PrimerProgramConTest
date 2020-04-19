using System;
using Prog2_18_04_PrimerProgramConTest.Library;

namespace Prog2_18_04_PrimerProgramConTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeFormat date = new ChangeFormat("10/11/1977");
            DateToPrint.ConsolePrint(date);
        }

        
    }
}
