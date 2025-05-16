using System.Collections.Generic;

namespace MicrosoftWine
{
	public abstract class BaseNode
	{

	}
	public class TextNode : BaseNode, IHasLocalizationId
	{
		//...
		public string LocalizationId { get; protected set; }

	}
	public class NonTextNode : BaseNode
	{
		//...
	}

	public class Node
	{
		public string LocalizationId;
		public List<NodeButton> NodeButtons;

		//public Node() { }

		public Node(string ключЛокализации, List<NodeButton> кнопки)
		{
			LocalizationId = ключЛокализации;
			NodeButtons = кнопки;
		}
	}
}








