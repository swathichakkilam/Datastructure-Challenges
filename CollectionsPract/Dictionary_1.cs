using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPract
{
    class Dictionary_1
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        public static void ExecuteDictionary1()
        {

            string s = "root/a 1.txt(abcd) 2.txt(efgh)";
            char[] chArr = s.ToCharArray();
            bool isFirstSpaceOccured = false;

            bool isFileOpen = false;
            string directory = "";
            List<String> files = new List<string>();
            List<string> fileValues = new List<string>();

            string fileName = string.Empty;
            string fileContent = string.Empty;
            for (int i=0; i<chArr.Length; i++ )
            {
                if (chArr[i] == ' ')
                {
                    isFirstSpaceOccured = true;
                }

                if (chArr[i] == '(')
                {
                    isFileOpen = true;
                }
                
                if (chArr[i] == ')')
                {
                    isFileOpen = false;

                    files.Add(fileName);
                    fileValues.Add(fileContent);

                    fileName = "";
                    fileContent = "";
                }

                if (!isFirstSpaceOccured)
                {
                    directory = directory + chArr[i];
                }
                
                if (isFirstSpaceOccured && !isFileOpen && chArr[i] != ' ')
                {
                    fileName = fileName + chArr[i];
                }

                if (isFirstSpaceOccured && isFileOpen && chArr[i] != '(')
                {
                    fileContent = fileContent + chArr[i];
                }
            }

        }
    }
}
