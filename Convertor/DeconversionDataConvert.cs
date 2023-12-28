using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor {
    public class DeconversionDataConvert {
        public bool Success { get; set; }
        public string Terms { get; set; }
        public string Privacy { get; set; }
        public class Query {
            public string From { get; set; }
            public string To { get; set; }
            public double Amount { get; set; }
        }
        public class Info {
            public long Timestamp { get; set; }
            public double Qoute { get; set; }
        }
        public double Result { get; set; }

    }
}
