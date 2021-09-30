using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Library.Patterns
{
    public class PatternIsNulllOrNotNull
    {
        public bool IsNull(int? a) => a is null;
        public bool IsNotNull(int? a) => a is not null;
    }
}
