using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class Program
    {

        public static void Main(string[] args)
        {
            HashMap hashMap = new HashMap
            {
                HashMapList = new List<KeyValuePair>()
            };
            hashMap.AddToHashMap("vava", 234);
            hashMap.AddToHashMap("miau", 23);
            hashMap.AddToHashMap("haha", 43);
            hashMap.AddToHashMap("wewe", 91);
            hashMap.AddToHashMap("tere", 354);
            hashMap.AddToHashMap("bede", 304);
            hashMap.AddToHashMap("meme", 0);
            hashMap.ReadAllFromHashMap();
            //hashMap.ReadFromHashMap("vava");
            hashMap.ReadFromHashMap("tere");
            hashMap.ReadFromHashMap("miau");
            //hashMap.DeleteFromHashMap("huhu");
            //hashMap.DeleteFromHashMap("tere");
        }
    }
}
