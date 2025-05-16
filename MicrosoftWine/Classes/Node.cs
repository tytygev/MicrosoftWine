using MicrosoftWine.ParcerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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








