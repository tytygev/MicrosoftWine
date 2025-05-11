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
		
        public void AddNode(int id)
		{
			var node = new Node(id);
			Nodes.Add(node);
        }
 
        void AddLink()
		{
		
		}
 
        public Node FindNextNode(int currentNode, List <Link> current)
        {
            Node findNextNode = currentNode;
            foreach (var a in Links)
            {
                if (a.From.Equals(currentNode)) { if (a.LinkMass == inputMass) { return findNextNode; } }
            }

            return findNextNode;
        }

    }

	

	
}
