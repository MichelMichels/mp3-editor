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

        /**
         * Constructor
         */
        public ID3Header(byte[] bytes)
        {
            if(bytes.Length < 10)
            {
                Console.WriteLine($"DEBUG ID3Header(byte[] bytes)     {bytes.Length}");
            } else
            {
                // set version
                MajorVersion = bytes[3];
                RevisionNumber = bytes[4];

                // set flags
                UnsynchronisationFlag = (bytes[5] & 0x80) == 0x00 ? false : true;
                ExtendedHeaderFlag = (bytes[5] & 0x40) == 0x00 ? false : true;
                ExperimentalIndicatorFlag = (bytes[5] & 0x20) == 0x00 ? false : true;

                // tag size
                TagSize = CalculateID3TagSize(new byte[] { bytes[6], bytes[7], bytes[8], bytes[9] });
            }
        }

        private int CalculateID3TagSize(byte[] array)
        {
            // initialize variable
            int totalSize = 0;

            for (int i = 0; i < 4; i++)
            {
                totalSize += array[3 - i] << 7 * i;
            }

            return totalSize;
        }

    }
}
