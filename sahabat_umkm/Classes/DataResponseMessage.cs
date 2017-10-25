using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahabat_umkm.Classes
{
    public class DataResponseMessage
    {
        public bool status { set; get; }
        public string remark { set; get; }
        public object data { set; get; }
        public string message { get; set; }
    }
}
