using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Specflow.CustomeException
{
    public class DebugExceptions
    {
        public static void LogException(String actionMessage, String exception, String logMessageOnException)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("----------------Start of log------------------");
            if (!String.IsNullOrEmpty(actionMessage))
            {
                message.AppendLine("Action-" + actionMessage);
            }
            if (!String.IsNullOrEmpty(exception))
            {
                message.AppendLine("Exception-" + exception);
            }
            if (!String.IsNullOrEmpty(logMessageOnException))
            {
                message.AppendLine("Message-" + logMessageOnException);
            }
            message.AppendLine("----------------End of log------------------");
            //Assert.Fail(message.ToString());
        }
    }
}
