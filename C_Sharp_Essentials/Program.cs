using C_Sharp_Essential_Library;

//ExceptionSamples.BasicExceptions();

try
    {
    ExceptionSamples.ThrowExceptions(true);
    }
catch(Exception ex)
    {
    throw; // ex; // Console.WriteLine(ex);
    }