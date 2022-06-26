using System;
using System.Runtime.CompilerServices;

// Indexer -- This program demonstrates the use if the index operator to provide access 
//    to an array using a string as an index. This version is nongeneric, but see the 
//    IndexerGeneric example.

namespace Indexer
{
    public class KeyedArray
    {
        // The following string provides the "key" into the array --
        // the key is the string used to identify an element.
        private string[] _keys;

        // The object is the actual data associated with that key 
        private object[] _arrayElements;

        // KeyedArray -- Create a fixed-size KeyedArray
        public KeyedArray(int size)
        {
            _keys = new string[size];
            _arrayElements = new object[size];
        }
    }
}