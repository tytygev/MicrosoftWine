using MicrosoftWine.ParcerClasses;

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
