using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch07Ex02
{
    class Program
    {
        static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };

        static void Main(string[] args)
        {
            foreach (string eType in eTypes)
            {
                try
                {
                    WriteLine("Main() try block reached.");   // Line 21
                    WriteLine($"ThrowException(\"{eType}\") called.");
                    ThrowException(eType); // 抛出异常后就不继续执行try块里剩余代码，
                    WriteLine("\nMain() try block continues.\n");   // Line 23
                }
                catch (System.IndexOutOfRangeException e) when (eType == "filter")
                {
                    WriteLine("Main() FILTERED System.IndexOutOfRangeException" +
                        $"catch block reached. Message:\n\"{e.Message}\"");
                }
                catch (System.IndexOutOfRangeException e)   // Line 32
                {
                    WriteLine("Main() System.IndexOutOfRangeException catch " +
                        $"block reached. Message:\n\"{e.Message}\"");
                }
                catch // Line 36 相当于默认System.Exception
                {
                    //WriteLine("Main() general catch block reached. Message:\n" + e.Message);
                    WriteLine("Main() general catch block reached.");
                }
                finally
                {
                    WriteLine("Main() finally block reached.");
                    WriteLine("_____________________________________________");
                }
                WriteLine();
            }
            ReadKey();
        }
        static void ThrowException(string exceptionType)
        {
            WriteLine($"ThrowException(\"{exceptionType}\") reached.\n");
            
            switch (exceptionType)
            {
                case "none":
                    WriteLine("Not throwing an exception.");
                    break;  // Line 57
                case "simple":
                    WriteLine("Throwing System.Exception.");
                    throw new System.Exception();   // Line 60
                case "index":
                    WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[5] = "error";    // Line 63
                    break;
                case "nested index":
                    try    // Line 66
                    {
                        WriteLine("ThrowException(\"nested index\") " +
                            "try block reached.");
                        WriteLine("ThrowException(\"index\") called.");
                        ThrowException("index");
                        // Line 71
                    }
                    catch   // Line 73
                    {
                        WriteLine("ThrowException(\"nested index\") general"
                            + " catch block reached.");
                        throw; // 重新引发catch捕获的异常
                    }
                    finally
                    {
                        WriteLine("ThrowException(\"nested index\") finally"
                            + " block reached.");
                    }
                    break;
                case "filter":
                    try    // Line 86
                    {
                        WriteLine("ThrowException(\"filter\") " +
                            "try block reached.");
                        WriteLine("ThrowException(\"index\") called.");
                        ThrowException("index");    // Line 91
                    }
                    catch   // Line 93
                    {
                        WriteLine("ThrowException(\"filter\") general"
                            + " catch block reached.");
                        throw;
                    }
                    break;
            }
        }
    }
}
