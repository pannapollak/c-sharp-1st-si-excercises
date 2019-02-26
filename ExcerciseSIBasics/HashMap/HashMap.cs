using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class HashMap
    {
        public List<KeyValuePair> HashMapList { get; set; }


        public void AddToHashMap(string key, int value)
        {
            KeyValuePair newPair = new KeyValuePair(key, value);
            foreach (var hash in HashMapList)
            {
                if (hash.Key == key)
                {
                    throw new ArgumentException("key aready exists");
                }
            }
            HashMapList.Add(newPair);
        }

        public int ReadFromHashMap(string key)
        {
            foreach (var hash in HashMapList)
            {
                if (hash.Key == key)
                {
                    return hash.Value;
                }
            }
            return 0;
        }

        public void ReadAllFromHashMap()
        {
            foreach (var pairs in HashMapList)
            {
                Console.WriteLine(pairs.Value);
            }
        }

        public string DeleteFromHashMap(string key)
        {
            foreach (var hash in HashMapList)
            {
                if (hash.Key == key)
                {
                    HashMapList.Remove(hash);
                    return "Key deleted";
                }
            }
            return "no key to delete";
        }
    }
}
