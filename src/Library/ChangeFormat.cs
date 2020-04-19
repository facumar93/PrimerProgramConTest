using System;
using System.Collections;

namespace Prog2_18_04_PrimerProgramConTest.Library
{
    public class ChangeFormat
    {
        public ChangeFormat(string input)
        {
            this.GetSetInput = input;
            
        }
        public string GetSetInput { get; set; }
        public string FSlachToDash()
        {
            string result = "";
            result = GetSetInput.Substring(6) + " " + GetSetInput.Substring(3,2) + "-" + GetSetInput.Substring(0,2);
            return result;
        }



    }
}
