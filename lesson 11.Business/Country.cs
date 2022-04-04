using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11.Business
{
    public class Country
    {
        public string Code { get; }
        public string Name { get; }

        public Country(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
