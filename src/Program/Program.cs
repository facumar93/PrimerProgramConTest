using System;
using Prog2_18_04_PrimerProgramConTest.Library;

namespace Prog2_18_04_PrimerProgramConTest
{
    class Program
    {
        static void Main(string[] args)

        {
            CheckDateExist toDate1 = new CheckDateExist("10/11/1977"); // Se instancia una posible fecha.
            
            if ( toDate1.CheckExist() == true) // Si la fecha existe se hace instancia de una clase que cambia el fortamo de una fecha.
            {
             ChangeFormat date = new ChangeFormat(toDate1);
             DateToPrint.ConsolePrintFSlashToBash(date);
             DateToPrint.ConsolePrintChangeOrder(date);
            }
            else
                Console.WriteLine("Fecha incorrecta.");
            
        }

               

        
    }
}
