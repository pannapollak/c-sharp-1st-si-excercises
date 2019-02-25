using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class KeyValuePair
    {
        public KeyValuePair(string key, int value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public int Value { get; set; }
    }
}
