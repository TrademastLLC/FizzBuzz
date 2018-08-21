using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public IEnumerable<string> Numbers(int max = 100, Dictionary<int, string> pairs = null)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= max; i++)
            {
                sb.Clear();

                foreach (int key in pairs.Keys)
                {
                    if (i % key == 0)
                    {
                        sb.Append(pairs[key]);
                    }
                }

                if (sb.Length > 0)
                {
                    yield return i + " " + sb.ToString();
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}
