using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace MicrosoftWine
{
	class LocalizationController
	{
		public Dictionary<string, string> LocalizationDictionary;		
		


		public Dictionary<string, string> BuildLocalization()
		{
			const string LocalizationFile = "local.txt";
			const Char SeparatorChar = ';';

			Dictionary<string, string> locDic=new Dictionary<string, string>();

			StringReader file = new StringReader(LocalizationFile);

			string line;
			while ((line = file.ReadLine()) != null)
			{
				string[] pairs = line.Split(SeparatorChar);
				string key = pairs[0];
				string value = pairs[1];
                locDic.Add(key, value);
            }
			return locDic;
        }
	}
}
