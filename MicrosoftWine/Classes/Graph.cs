using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine
{
	class Graph
	{
		public List<Node> Nodes;
		public List<Link> Links;
        
        public Graph()
        {

        }

        public Graph(List<Link> links, List<Node> nodes)
        {
			Nodes = nodes;
            Links = links;
        }
		
        public void AddNode(string idЛокализации, List<NodeButton> кнопкиНоды)
		{
			Node node = new Node(idЛокализации, кнопкиНоды);
			Nodes.Add(node);
        }
        

        public void AddLink(int откуда, int куда)
		{
            Link дуга = new Link(откуда, куда);
            Links.Add(дуга);
        }
 
        //public Node FindNextNode(int currentNode, List <Link> current)
        //{
        //    //Node findNextNode = currentNode;
        //    //foreach (var a in Links)
        //    //{
        //    //    if (a.From.Equals(currentNode)) { if (a.LinkMass == inputMass) { return findNextNode; } }
        //    //}

        //    //return findNextNode;
        //}

    }

	

	
}
