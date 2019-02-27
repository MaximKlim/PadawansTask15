using System;
using System.Collections.Generic;
using System.Linq;

namespace PadawansTask15
{
    public class EnumerableTask
    {
        public IEnumerable<string> GetUppercaseStrings(IEnumerable<string> data)
        {
            IEnumerator<string> ie = data.GetEnumerator();

            List<string> result = new List<string>();

            string newItem;

            while (ie.MoveNext())
            {
                string item = ie.Current;
                if (!string.IsNullOrEmpty(item))
                {
                    newItem = item.ToUpper();
                }
                else
                {
                    newItem = item;
                }

                result.Add(newItem);
            }
            return result;
        }


        public IEnumerable<int> GetStringsLength(IEnumerable<string> data)
        {
            List<int> result = new List<int>();
            int temp;

            foreach (string e in data)
            {
                if (e == null)
                {
                    result.Add(0);
                }
                else
                {
                    result.Add(e.Length);
                }

            }
            return result;
        }


        public IEnumerable<long> GetSquareSequence(IEnumerable<int> data)
        {
            long temp;
            List<long> result = new List<long>();

            foreach (int e in data)
            {
                temp = e * e;
                result.Add(temp);
            }
            return result;
        }


        public IEnumerable<string> GetPrefixItems(IEnumerable<string> data, string prefix)
        {
            List<string> result = new List<string>();

            if (prefix == null)
            {
                throw new ArgumentNullException { };
            }
            string prefixLow = prefix.ToLower();
            string prefixUp = prefix.ToUpper();



            foreach (string e in data)
            {
                if (e == null)
                {
                }
                else if ((e.StartsWith(prefixLow)) || (e.StartsWith(prefixUp)))
                {
                    result.Add(e);
                }

            }
            return result;
        }


        public IEnumerable<int> Get3LargestItems(IEnumerable<int> data)
        {
            List<int> list = new List<int>();
            int a;
            List<int> result = new List<int>();

            list.AddRange(data);
            list.Sort();

            for (int i = 1; i <= 3; i++)
            {
                if (list.Count == 0)
                {
                    break;
                }
                else
                {
                    a = list.Max();
                    result.Add(a);
                    list.Remove(a);
                }

            }

            return result;
        }

        public int GetSumOfAllIntegers(object[] data)
        {

            int sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is int)
                {
                    sum = sum + (Convert.ToInt32(data[i]));
                }
            }
            return sum;
        }
    }
}