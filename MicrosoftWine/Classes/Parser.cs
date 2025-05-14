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
    class Parser
    {
        
        Graph graph =new Graph();
        ResourcesController resourcesController = new ResourcesController();

        public void AddNodeButton(string idЛокализации)
        {
           
        }

        public void ParseGraph()
        {
            string line;
            List<string> list = new List<string>();
            StringReader file = new StringReader("adjlist.txt");

            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
            }

            int countList = list.Count;
            int i= 0;   

            //парсим ноды
            //N: a, b, c;pict1.jpg;some,yes,no
            foreach (string listline in list)
            {
                List<NodeButton> NodeButtons= new List<NodeButton>();
        //получение массива слов по ТЧКСЗПТ               
        string[] wordsLine = listline.Split(';');

                //получение массива слов по ДВОЕТОЧ
                string[] wordsNode = wordsLine[0].Split(':');
                
                //получение массива целевых нод по ЗПТ                
                string[] wordsNodeTo = wordsNode[1].Split(',');
                // не забыть подрезку пробелов .Trim() !!!!!!!!!!!
                
                //получение массива кнопок по ЗПТ
                string[] wordsButt = wordsLine[2].Split(',');

                //анализ связей.
                //при двух связях и пустом третьем параметре -
                //умолчание:
                //первая слева - да, вторая - нет.
                //иначе - в соответсвии с третьим параметром.
                //Если третий параметр пуст... ??

                if (wordsLine[2] != "")
                {
                    
                    foreach (string id in wordsButt)
                    {
                        string idT = id.Trim();
                        //AddNodeButton(idT);
                        NodeButton nodeButton = new NodeButton(idT);
                        NodeButtons.Add(nodeButton);
                    }
                    string idLoc = wordsNode[0].Trim();
                    graph.AddNode(idLoc, NodeButtons);
                }
                else
                {
                    
                }                    
            }           
        }             
    }
}
