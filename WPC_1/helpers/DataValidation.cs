using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.helpers
{
    public class DataValidation
    {

        public Boolean EmailValidation(string emailToValidate) 
        {
            try
            {
                MailAddress email = new MailAddress(emailToValidate);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        
        public Boolean PwdValidation(string pwd1, string pwd2)
        {
            try
            {
                pwd1.Equals(pwd2);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public Boolean validarInt(string textToValidate)
        {
            try
            {
                int num = Int32.Parse(textToValidate);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static string ValidarEntradaDades(string camp1, string camp2)
        {
            if (string.IsNullOrEmpty(camp1))
                return camp1;  

            else if (string.IsNullOrEmpty(camp2))
                return camp2;            
        }
    }
}
