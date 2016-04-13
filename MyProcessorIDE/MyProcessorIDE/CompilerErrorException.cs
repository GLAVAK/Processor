using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProcessorIDE
{
    class CompilerErrorException : Exception
    {
        public string Text { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }

        public CompilerErrorException(string Text, int Line, int Column)
        {
            this.Text = Text;
            this.Line = Line;
            this.Column = Column;
        }
    }
}
