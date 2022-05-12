using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage
{   
    //klasa odpowiadająca za wyjątki
    public class ProgramExceptions : Exception
    {
        public ProgramExceptions() { }
        public ProgramExceptions(String msg) : base(msg) { }
    }
    //Do wyłapywania zderzeń
    public class CrashException : ProgramExceptions
    {
        public CrashException(String msg) : base(msg) { }
    }
    // niezapisanie mapy przed wyjściem z programu
    public class ExitWithoutSaveException : ProgramExceptions
    {
        public ExitWithoutSaveException(String msg) : base(msg) { }
    }
    // podana wartość < 0
    public class NegativeValueException : ProgramExceptions
    {
        public NegativeValueException(String msg) : base(msg) { }
    }
    // nie podano żadnej wartości
    public class EmptyValueException : ProgramExceptions
    {
        public EmptyValueException(String msg) : base(msg) { }
    }
    //Podano za małą wartosc
    public class TooLowValueException : ProgramExceptions
    {
        public TooLowValueException(String msg) : base(msg) { }
    }
    

}