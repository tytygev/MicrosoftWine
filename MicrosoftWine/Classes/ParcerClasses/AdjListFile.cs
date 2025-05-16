using System.Collections.Generic;
using System.IO;

namespace MicrosoftWine.ParcerClasses
{
	public class AdjListFile
	{
		public List<AdjListLine> AdjListLines;

		public AdjListLine GetLine(int index)
		{
			return AdjListLines[index];
		}

		public int GetCount()
		{
			return AdjListLines.Count;
		}

		public AdjListFile AdjListFileBuild(string FilePath)
		{
			AdjListLines = new List<AdjListLine>();
			StringReader file = new StringReader(FilePath);
			string line;

			while ((line = file.ReadLine()) != null)
			{
				AdjListLine adjListLine = new AdjListLine();
				adjListLine.AdjListLineBuild(line);
				AdjListLines.Add(adjListLine);
			}

			return this;
		}
	}
}
