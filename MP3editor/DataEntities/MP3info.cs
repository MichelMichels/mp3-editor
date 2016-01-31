using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class MP3info
    {
        // Master byte list
        public List<byte> MP3Bytes = new List<byte>();

        // Header and or extended header
        public ID3Header Header { get; set; }
        public ID3ExtendedHeader ExtendedHeader { get; set; }

        // save ID3 frames
        public List<ID3Frame> Frames = new List<ID3Frame>();

        public MP3info()
        {
            Header = new ID3Header();
            ExtendedHeader = new ID3ExtendedHeader();
            Frames = new List<ID3Frame>();
        }

        public MP3info(ID3Header header, List<ID3Frame> frames) {
            Header = header;
            this.Frames = frames;
        }

        public MP3info(ID3Header header, ID3ExtendedHeader extendedHeader, List<ID3Frame> frames)
        {
            Header = header;
            ExtendedHeader = extendedHeader;
            this.Frames = frames;
        }
    }
}
