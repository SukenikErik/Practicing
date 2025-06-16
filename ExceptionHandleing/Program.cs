
using ExceptionHandleing;
using ExceptionHandleing.Exceptions;

internal class Worker: IErrorTester
{
    public void DoError1()
    {
        throw new Exception("Incorrect parameter");
    }

    public void DoNullError()
    {
        throw new ArgumentNullException("Reference is Null");
    }

    public void DoExamError()
    {
        throw new ExamComing("Adatb 1");
    }

    public void DoError()
    {
        DoExamError();
    }
}