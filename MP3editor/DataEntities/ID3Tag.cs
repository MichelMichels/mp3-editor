using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class ID3Tag
    {
        /**
         * Fields
         */
        private byte[] _bytes;
        
        /**
         * Properties
         */
        public byte[] Bytes
        {
            get
            {
                return _bytes;
            }
            set
            {
                _bytes = new byte[value.Length];
                _bytes = value;
            }
        }

        // Header and or extended header
        public ID3Header Header { get; set; }
        public ID3ExtendedHeader ExtendedHeader { get; set; }

        // save ID3 frames
        public List<ID3Frame> Frames { get; set; }

        /**
         * Constructor
         */
        public ID3Tag()
        {
            // Properties
            Header = new ID3Header();
            ExtendedHeader = new ID3ExtendedHeader();
            Frames = new List<ID3Frame>();
        }

        /**
         * Methods
         */
        public bool HasID3Identifier()
        {
            if(Bytes[0] == 0x49 && Bytes[1] == 0x44 && Bytes[2] == 0x33)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void PrintFrames()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"PrintFrames() - ID3Tag.cs");
            foreach(ID3Frame frame in Frames)
            {
                Console.WriteLine(frame);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
