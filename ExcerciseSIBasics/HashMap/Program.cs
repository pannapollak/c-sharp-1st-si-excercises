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
            HashMap hashMap = new HashMap();
            hashMap.AddToHashMap("vava", 234324);
            hashMap.ReadFromHashMap("huhu");
            hashMap.DeleteFromHashMap("huhu");
        }
    }
}
