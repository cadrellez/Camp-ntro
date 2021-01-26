using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryWork
{
    class MyDictionary<Tkey, Tvalue>
    {

        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] ktempArray = keys;
            Tvalue[] vtempArray = values;
            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];
            for (int i = 0; i < ktempArray.Length; i++)
            {
                keys[i] = ktempArray[i];
            }
            for (int i = 0; i < vtempArray.Length; i++)
            {
                values[i] = vtempArray[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;




        }
        public Tkey[] key
        {

            get { return keys; }

        }
        public Tvalue[] value
        {
            get { return values; }

        }

    }
}
