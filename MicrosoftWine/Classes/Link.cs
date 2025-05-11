using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine
{
    class Link
    {
        public readonly int From;

        public readonly int To;

        public Link(int from, int to)
        {
            From = from;
            To = to;
        }
    }
}
