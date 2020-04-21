using System;

namespace Prog2_18_04_PrimerProgramConTest.Library
{
    public class DateToPrint
    {

        public static void ConsolePrintFSlashToBash(ChangeFormat date)
        {
            Console.WriteLine(date.FSlashToDash());
        }
        public static void ConsolePrintChangeOrder(ChangeFormat date)
        {
            Console.WriteLine(date.ChangeOrder());
        }
    }
}