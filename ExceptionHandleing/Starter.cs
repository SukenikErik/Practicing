using ExceptionHandleing.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleing
{
    internal class Starter
    {
        public static void Main()
        {
            try
            {
                IErrorTester worker = new Worker();
                //worker.DoError();
                //worker.DoNullError();
                worker.DoError();
            }
            catch (ExamComing e)
            {
                throw;
            }
            catch (ArgumentNullException ane){
                Console.WriteLine("Argument Null");
            }

            catch (Exception e){ 
                Console.WriteLine(e.ToString());
            }

        }
    }

    
}
