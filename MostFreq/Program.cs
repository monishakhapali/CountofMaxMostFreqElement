using System;
using System.Collections;
using System.Linq;

namespace MostFreq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] arr =  { 3,2,5,6,6,7};
            freq(arr);



        }
        static void freq(int[] arr)
        {
            Hashtable hashtable = new Hashtable();
            //int count = 1;
            int max = 0;
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashtable.Contains(arr[i]))
                {
                    hashtable[arr[i]] = ((int)hashtable[arr[i]] + 1);
                    //hashtable[arr[i]] = count + 1;
                    //count = 1;

                }
                else
                {
                    // hashtable.Add(arr[i],1);
                    hashtable[arr[i]] = 1;
                }

            }
            foreach (DictionaryEntry pair in hashtable)
            {
                if ((int)pair.Value > max)
                {
                    res = (int)pair.Key;
                    max = (int)pair.Value;

                }


            }
            //res = hashtable.Keys.OfType<int>().FirstOrDefault(s => (int)hashtable[s] == max);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
