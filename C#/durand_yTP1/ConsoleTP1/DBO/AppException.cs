using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.DBO
{
    class AppException: Exception
    {
        public AppException(String message, Exception ex)
        {

        }
    }
}
