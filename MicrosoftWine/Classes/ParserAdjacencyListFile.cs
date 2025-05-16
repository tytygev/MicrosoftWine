using MicrosoftWine.ParcerClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace MicrosoftWine
{
    class ParserAdjacencyListFile
    {
        public AdjListFile AdjListFile;
        const string FilePath = "adjlist.txt";//N: a, b, c;filepath;some,yes,no

        public AdjListFile Parse()
        {
            AdjListFile adjListFile = new AdjListFile();
            adjListFile.AdjListFileBuild(FilePath);
            return adjListFile;
        }

              
        }             
    }
