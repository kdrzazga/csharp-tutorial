using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Functions
    {

        public Func<int, int> square = (x) => x * x;

        public Func<int, int> negate = x => x * -1;
        public Func<int, string> toString = s => s.ToString();
        public Func<string, int> stringLen = s => s.Length;
        
    }
}
