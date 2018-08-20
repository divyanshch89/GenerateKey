using System.Collections.Generic;

namespace GenerateKey.Models
{
    public class Keys
    {
        public string Source_WO_ID { get; set; }
        public string Unified_WO_ID { get; set; }
        public string Target_WO_ID { get; set; }
        public List<SourceCompositeElement> SourceCompositeElements { get; set; }
    }
}