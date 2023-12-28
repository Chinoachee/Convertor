using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor {
    public class DeconversionData {
        public bool Success { get; set; }
        public string Terms { get; set; }
        public string Privacy { get; set; }
        public long TimeStamp { get; set; }
        public string Source { get; set; }
        public QuotesDate Quotes { get; set; }
    }
}
