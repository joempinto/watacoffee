using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC_1.responses;

namespace WPC_1.helpers
{
    public class ErrorList
    {
        public static void ResponseNoSuccess(responses.ServerResponse message) 
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show("\nMessage: " + message.message, "Error: " + message.status, button, icon);
        }
    }
}
