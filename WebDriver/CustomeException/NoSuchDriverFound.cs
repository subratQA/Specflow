using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver.CustomeException
{
    public class NoSuchDriverFound:Exception
    {
        public NoSuchDriverFound(String msg):base(msg)
        {

        }
    }
}
