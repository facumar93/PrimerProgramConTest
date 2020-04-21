using System;

namespace Prog2_18_04_PrimerProgramConTest.Library
{
    public class CheckDateExist // Esta clase verificará si la fecha existe.
    {   
        public CheckDateExist(string toDate)
        {
            this.ToDate = toDate;
        }
        public string ToDate { get; set; }
       
        public bool CheckExist()
        {
            int FSlashContador = 0;
            foreach ( char caracter in this.ToDate ) // Hay dos separadores "/"?,
            {
                if ( caracter == '/')
                {
                    FSlashContador += 1;
                }
            }
            if ( FSlashContador != 2 )
            {
                return false;
            }
            
            string[] dateArray = this.ToDate.Split('/'); //Split de string fecha.
            
            foreach (string elem in dateArray)
            {
                
                foreach (char character in elem)
                {
                    if (!("0,1,2,3,4,5,6,7,8,9".Contains(Convert.ToString(character)))) //Cada caracter es un número?
                    {
                        return false;
                    }
                }
            }
            
            //Se verifica si la fecha existe como tal.

            if ( Convert.ToInt32(dateArray[1]) == 4 || Convert.ToInt32(dateArray[1]) == 6
                  || Convert.ToInt32(dateArray[1]) == 9 || Convert.ToInt32(dateArray[1]) == 11 )
                  
            {
                if (! (Convert.ToInt32(dateArray[0]) >= 1 && Convert.ToInt32(dateArray[0]) <= 30) )
                {
                    return false;
                }
            }
            
            if ( Convert.ToInt32(dateArray[1]) == 1 || Convert.ToInt32(dateArray[1]) == 3
                  || Convert.ToInt32(dateArray[1]) == 5 || Convert.ToInt32(dateArray[1]) == 7
                  || Convert.ToInt32(dateArray[1]) == 8 || Convert.ToInt32(dateArray[1]) == 10
                  || Convert.ToInt32(dateArray[1]) == 12 )
                  
            {
                if  (!(Convert.ToInt32(dateArray[0]) >= 1 && Convert.ToInt32(dateArray[0]) <= 31)) 
                {
                    return false;
                }
            }
            // Se tiene en cuenta que febrero es bisiesto.
            if ( Convert.ToInt32(dateArray[1]) == 2 )
            {
                
                if (! (Convert.ToInt32(dateArray[0]) >= 1 && Convert.ToInt32(dateArray[0]) <= 29) )
                {
                    return false;
                }
                if ( Convert.ToInt32(dateArray[0]) == 29 )
                {
                    if (!(Convert.ToInt32(dateArray[2]) % 4 == 0 && (! (Convert.ToInt32(dateArray[2]) % 100 == 0))
                    || Convert.ToInt32(dateArray[2]) % 400 == 0))
                    {
                        return false;
                    }
                }

            }
            return true; //Retorna verdadero si ninguna prueba retorna falso.
        }
    }
}