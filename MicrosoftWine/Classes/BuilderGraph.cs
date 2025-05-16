using MicrosoftWine.ParcerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine
{
     class BuilderGraph
    {
        //   ResourcesController resourcesController = new ResourcesController();

        public Graph BuildGraph()
        {
            var graph = new Graph();

            BuildNodes(graph);
            BuildLinks(graph);

            return graph;
        }

        void BuildNodes(Graph graph)
        {
            ParserAdjacencyListFile file = new ParserAdjacencyListFile();
            AdjListFile adjList = file.Parse();
                                  
            for (int i =0;i < adjList.GetCount();i++)
            { 
                string nodeID = adjList.GetLine(i).NodeID.Text;
                List<NodeButton> buttonsID = adjList.GetLine(i).ButtonsLocalizationSet;
                graph.AddNode(nodeID, buttonsID);
            }
        }

        void BuildLinks(Graph graph)
        {
ParserAdjacencyListFile file = new ParserAdjacencyListFile();
            AdjListFile adjList = file.Parse();

            for (int from = 0; from < graph.GetNodesCount(); from++)
            {                
                for (int n = 0; n < adjList.GetLine(from).GetCountNodesLinks(); n++)
                {
                    string adjNode = adjList.GetLine(from).GetNodesLinks(n).Text;                                        
                    int to = graph.FindNodeIndex(adjNode);
                    graph.AddLink(from, to);
                }
            }
        }

       
    }
}
