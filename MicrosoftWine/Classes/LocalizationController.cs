using System.Collections.Generic;
using System.IO;

namespace MicrosoftWine
{
	class LocalizationController
	{
		Dictionary<int, string> LocDic = new Dictionary<int, string>();
		string localData = "local.txt";


		public void LocalizationFileParcer(string path)
		{

			string line;
			StringReader file = new StringReader(path);

			while ((line = file.ReadLine()) != null)
			{

			}
		}
	}
}
