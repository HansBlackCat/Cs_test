using System;

namespace Application
{
    public static void Main(string[] args)
    {
        try
        {
            args + args;
        }
        catch (Exception ex)
        {
            Log(ex);
            throw;
        }

    }
}

namespace MyNamespace
{
    class A
    {

    }
    class B
    {

    }

}

