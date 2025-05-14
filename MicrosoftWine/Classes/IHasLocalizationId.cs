using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine
{
    public interface IHasLocalizationId
    {
        string LocalizationId { get; } 
        // интерфейс обязывает только иметь возможность прочитать свойство
    }
}
