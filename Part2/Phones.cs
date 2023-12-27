using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Phones
    {
        public Dictionary<int, string> dict = new Dictionary<int, string>();

        public void CreateDictionary(int phoneNumber, string fullname)
        {
            dict.Add(phoneNumber, fullname);
        }

        public string DictionaryFindById(int id)
        {
            string searchResult = "";
            if (dict.ContainsKey(id))
            {
                searchResult = dict[id];
            }
            else
            {
                searchResult = "Данного пользователя нет";
            }
            return searchResult;
        }

        public string DictionaryString()
        {
            string dictString = "";
            foreach (KeyValuePair<int, string> kvp in dict) { dictString = dictString + kvp.Key + ": " + kvp.Value + ", "; }
            return dictString;
        }
    }
}
