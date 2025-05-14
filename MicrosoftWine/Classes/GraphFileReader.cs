using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine
{
     class GraphFileReader
    {
        string graphData = "adjlist.txt";
        string localData = "local.txt";


        public void read(string path)
        {
            
            string line;
            StringReader file = new StringReader(path);

            while ((line = file.ReadLine()) != null)
            {

            }
        }
    }
}
