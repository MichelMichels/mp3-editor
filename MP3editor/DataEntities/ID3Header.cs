using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class ID3Header
    {
        // All header bytes
        public List<byte> HeaderBytes { get; set;  }

        // 4th and 5th byte
        public int MajorVersion { get; set; }
        public int RevisionNumber { get; set; }

        // 6th byte (abc0 0000)
        public bool UnsynchronisationFlag { get; set; }
        public bool ExtendedHeaderFlag { get; set; }
        public bool ExperimentalIndicatorFlag { get; set; }

        // byte 7, 8, 9, 10
        // tag size = total tag size - 10
        public int TagSize { get; set; }
    }
}
