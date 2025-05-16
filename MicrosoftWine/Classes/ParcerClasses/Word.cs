using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine.ParcerClasses
{
    public class Word
    {
        public string Text;

        public Word(string text)
        {            
            Text = text.Trim();
        }
    }
}
