using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine
{
    class Link //: IHasLocalizationId
    {
        public readonly int From;

        public readonly int To;

        //public string LocalizationId { get; protected set; }

        public Link(int from, int to)
        {
            From = from;
            To = to;
        }        
    }    
}
