using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftWine.ParcerClasses
{
    public class AdjListLine
    {
        public Word NodeID;
        public List<Word> NodesLinks;
        public Word PathResFile;
        public List<NodeButton> ButtonsLocalizationSet;
        const int IndexFirstSentence = 0;
        const int IndexSecondSentence = 1;
        const int IndexThirdSentence = 2;

        public AdjListLine AdjListLineBuild(string text) 
        {
            string[] Sentences = text.Split(';');
            string[] subSentence = Sentences[IndexFirstSentence].Split(':');

            Word nodeID = new Word(subSentence[IndexFirstSentence]);
            NodeID = nodeID;

            NodesLinks = new List<Word>();
            string[] words = subSentence[IndexSecondSentence].Split(',');
            foreach (string item in words)
            {
                Word nodeLink = new Word(item);
                NodesLinks.Add(nodeLink);
            }

            Word pathResFile = new Word(Sentences[IndexSecondSentence]);
            PathResFile = pathResFile;

            ButtonsLocalizationSet = new List<NodeButton>();
            words = Sentences[IndexThirdSentence].Split(',');
            foreach (string item in words)
            {
                NodeButton buttID = new NodeButton(item);
                ButtonsLocalizationSet.Add(buttID);
            }

            return this;
        }

        public Word GetNodesLinks(int index)
        {
            return NodesLinks[index];
        }

        public int GetCountNodesLinks()
        {
            return NodesLinks.Count;
        }
    }
}
