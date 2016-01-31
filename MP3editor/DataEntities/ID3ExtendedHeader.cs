using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class ID3ExtendedHeader
    {
        // Extended header
        public int ExtendedHeaderSize { get; set; }
        public bool CRCFlag { get; set; }
        public int SizeOfPadding { get; set; }
    }
}
