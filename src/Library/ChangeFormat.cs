using System;
using System.Collections;

namespace Prog2_18_04_PrimerProgramConTest.Library
{
    public class ChangeFormat
    {
        
        public ChangeFormat(CheckDateExist date)
        {
            this.Date = date;
            
        }
        public CheckDateExist Date { get; set; }
        
        public string FSlashToDash()
        {
            string result = "";
            result = this.Date.ToDate.Substring(6) + " " + this.Date.ToDate.Substring(3,2) + "-" + this.Date.ToDate.Substring(0,2);
            return result;
        }
        public string ChangeOrder()
        {
            string result = "";
            result =  this.Date.ToDate.Substring(0,2) + "/" + this.Date.ToDate.Substring(6) + "/" + this.Date.ToDate.Substring(3,2);
            return result;
        }



    }
}
