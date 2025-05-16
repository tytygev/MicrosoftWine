using System.Collections.Generic;

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
		public int GetNodesCount()
		{
			return Nodes.Count;
		}
		public Node GetNode(int index)
		{
			return Nodes[index];
		}

		public int FindNodeIndex(string nodeLocalizationID)
		{
			int index = -1;
			for (int i = 0; i < Nodes.Count; i++)
			{
				if (Nodes[i].LocalizationId == nodeLocalizationID)
					index = Nodes.IndexOf(Nodes[i]);
			}
			return index;
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
	}
}
