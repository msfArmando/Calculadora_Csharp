using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp
{
    public class OperacoesException : IOException
    {
        public OperacoesException()
        {
        }

        public OperacoesException(string message) : base(message) { }

        public OperacoesException(string message, IOException innerException) : base(message, innerException) { }
    }
}
