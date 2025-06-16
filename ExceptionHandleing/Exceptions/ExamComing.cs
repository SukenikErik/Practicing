using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleing.Exceptions
{
    internal class ExamComing: Exception
    {
        public ExamComing(string messege): base(messege) { 
           
        }
    }
}
