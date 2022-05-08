using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.APIModels
{
    public class APIResponse<T>
    {
        public bool hasError { get; set; }
        public string message { get; set; }
        public T successData { get; set; }
    }
}
