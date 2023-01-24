using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure2022.HashTable
{
    public class HashTable
    {
        public string[] _hashTable {get; set;}
        public HashTable() 
        {
            _hashTable = new string[10];
        }

        // this is VERY VERY  weak hashing algorytm
        
        private int  _hash(string key)
        {
            return key.Length % _hashTable.Length;

        }

        public void Set(string key, string value)
        {
            int hashedKey = _hash(key);
            if (_hashTable[hashedKey] != null) 
            {
                Console.WriteLine("Hash collision has occurred");
            }
            else
            {
                _hashTable[hashedKey]= value;
            }

        }

        public string Get(string key)
        {
            int hashedKey = _hash(key);
            return _hashTable[hashedKey];


        }

    }
}
