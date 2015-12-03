using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCA.Core
{
    public class CoreFunction
    {
        public static string InnermostException(Exception exception)
        {
            string message = string.Empty;
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }
            message = exception.Message;

            return message;
        }
    }
}
