using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Alper");
            myDictionary.Add(2, "Ozdemir");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add(5, "Salih");
            Console.WriteLine(myDictionary.Count);

            Console.WriteLine("The items: ");
            for (int i = 0; i < myDictionary.KeyArray.Length; i++)
            {
                Console.WriteLine("Key : {0} \nValue : {1} ", myDictionary.KeyArray[i], myDictionary.ValueArray[i]);
            }
        }
    }

    public class MyDictionary<T, V>
    {
        //definitions for key and value arrays
        T[] kArray;
        V[] vArray;
        T[] tempkArray;
        V[] tempvArray;

        //constructor for dictionary
        public MyDictionary()
        {
            kArray = new T[0];
            vArray = new V[0];
        }
        //Adding key and values
        public void Add(T key, V val)
        {
            tempkArray = kArray;
            kArray = new T[kArray.Length + 1];
            tempvArray = vArray;
            vArray = new V[vArray.Length + 1];
            for (int i = 0; i < tempkArray.Length; i++)
            {
                kArray[i] = tempkArray[i];
            }
            kArray[kArray.Length - 1] = key;

            for (int j = 0; j < tempvArray.Length; j++)
            {
                vArray[j] = tempvArray[j];
            }
            vArray[vArray.Length - 1] = val;

        }
        //getting value of index 
        public V[] ValueArray
        {
            get { return vArray; }
        }
        //getting key of index
        public T[] KeyArray
        {
            get { return kArray; }
        }
        //getting the length of dictionary
        public int Count
        {
            get { return kArray.Length; }
        }
    }
}
