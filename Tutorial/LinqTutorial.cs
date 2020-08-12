using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class LinqTutorial
    {

        public IEnumerable<String> SelectNamesWithA(string[] names)
        {
            return from name in names
                   where name.Contains('a')
                   select name;
            /*You will not get the result of a LINQ query until you execute it.*/
        }
    }
}
