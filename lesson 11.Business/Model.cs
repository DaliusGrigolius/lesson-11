using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11.Business
{
    public class Model
    {
        public string ModelNumber { get; }
        public string ModelDescription { get; }

        public Model(string modelNumber, string modelDescription)
        {
            ModelNumber = modelNumber;
            ModelDescription = modelDescription;
        }
    }
}
