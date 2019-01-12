using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Common
{
    public class CommandResult
    {
        public bool Successful { get; set; }
        public Exception Exception { get; set; }
    }
}
