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
                    throw new System.ArgumentException("key aready exists");
                }
            }
            HashMapList.Add(newPair);
        }

        public void ReadFromHashMap(string key)
        {
            foreach (var hash in HashMapList)
            {
                if (hash.Key == key)
                {
                    Console.WriteLine(hash.Value);
                }

                throw new ArgumentException("no key found");
            }
        }

        public bool DeleteFromHashMap(string key)
        {
            foreach (var hash in HashMapList)
            {
                if (hash.Key == key)
                {
                    HashMapList.Remove(hash);
                    return true;
                }
            }
            return false;
        }
    }
}
