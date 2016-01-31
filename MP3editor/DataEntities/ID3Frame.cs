using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class ID3Frame
    {
        public string ID { get; set; }
        // frame size - header size = frame size - 10
        public int Size { get; set; }
        public byte[] Flags { get; set; }
    }
}
