using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine
{
	/// <summary>
	/// Дуга графа
	/// </summary>

	class Link
	{
		public Node From { get; }
		public Node To { get; }
		public bool LinkMass { get; }
		public Link(Node from, Node to, bool linkmass)
		{
			From = from;
			To = to;
			LinkMass = linkmass;
		}
	}

	/// <summary>
	/// Нода графа
	/// </summary>
	abstract class Node
	{
		int Id { get; }
		string Text { get; }


		public Node(int id, string text)
		{
			Id = id;
			Text = text;
		}
		
	}
	/// <summary>
	/// Простая нода с двумя исходящими связями
	/// </summary>
	class SimpleNode : Node
		{
			SimpleNode(int id, string text) : base(id, text)
			{
			}			
		}
	/// <summary>
	/// Конечная нода 
	/// </summary>
	class FinishNode : Node
		{
			FinishNode(int id, string text) : base(id, text)
			{

			}
			void FinishVoid() { }
		}

	/// <summary>
	/// Граф
	/// </summary>
	class Graph
	{

		/// <summary>
		/// Список вершин графа
		/// </summary>
		public List<Node> Nodes { get; }
		public Graph(List<Node> nodes) {

			Nodes = nodes;
		}
		/// <summary>
		/// Метод добавления ноды (вершины)
		/// </summary>
		/// <param name="id">индекс ноды</param>
		/// <param name="text">содержимое</param>
		void AddNode(int id, string text)
		{
		}

		/// <summary>
		/// Список дуг графа
		/// </summary>
		public List<Link> Links { get; }
		public Graph(List<Link> links)
		{

			Links = links;
		}
		/// <summary>
		/// Метод добавления дуги
		/// </summary>
		/// <param name="from">родительская нода </param>
		/// <param name="to">дочерняя нода</param>
		/// <param name="linkmass">вес дуги</param>
		void AddLink(Node from, Node to, bool linkmass)
		{
		}

		
	}
	/// <summary>
	/// Контроллер
	/// </summary>
	class Conductor { 
	/// <summary>
		/// Поиск ноды
		/// </summary>
		/// <param name="currentNode">текущая нода</param>
		/// <param name="currentMass">вес от юзера</param>		/// 
		/// <returns>Найденная нода</returns>
		public Node FindNode(Node currentNode, bool currentMass)
		{
			Node findNode = currentNode;
			foreach (var a in Graph.Links)
			{
				if (a.From.Equals(currentNode)){if (a.LinkMass == currentMass) { return findNode; }}
			}

			return findNode;
		}
	
	}
}
