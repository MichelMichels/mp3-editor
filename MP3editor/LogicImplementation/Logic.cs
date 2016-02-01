using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessImplementation;
using DataEntities;

namespace LogicImplementation
{
    public class Logic
    {
        DataHandler data = new DataHandler();

        // -------
        // Events
        // --------
        public event Action UnsupportedFile = () => { };

        // -----------
        // Constructor
        // -----------
        public Logic()
        {
            // Subscribe to DataHandler events
            data.BytesLoaded += (int count) => Console.WriteLine($"{count} bytes loaded.");
        }

        // ---------
        // Methods
        // ---------
        public MP3info GetSongInfo(string fileName)
        {
            // Create MP3 vars
            var songWrapper = new MP3info();
            var songHeader = new ID3Header();
                                   
            // Load header in byte array, header = 10 bytes
            var bytes = data.LoadBytes(fileName, 10);

            /////////////////////////////////////////////
            //
            //      bytes are ordered like this:
            //      
            //      XX XX XX YY YY ZZ AA AA AA AA
            //      0  1  2  3  4  5  6  7  8  9
            //      
            //      I  D  3  Mv Rv Fl Size ______
            //
            /////////////////////////////////////////////
            try {
                /*
                if (new char[(char)bytes[0], (char)bytes[1], (char)bytes[2]] != new char['I', 'D', '3'])
                {
                    throw (new ArgumentException("File not supported"));
                }
                */

                // set version
                songHeader.MajorVersion = bytes[3];
                songHeader.RevisionNumber = bytes[4];

                // set flags
                songHeader.UnsynchronisationFlag = (bytes[5] & 0x80) == 0x00 ? false : true;
                songHeader.ExtendedHeaderFlag = (bytes[5] & 0x40) == 0x00 ? false : true;
                songHeader.ExperimentalIndicatorFlag = (bytes[5] & 0x20) == 0x00 ? false : true;

                // tag size
                songHeader.TagSize = CalculateID3TagSize(new byte[] { bytes[6], bytes[7], bytes[8], bytes[9] });

                // DEBUG
                Console.WriteLine($"[DEBUG] Logic.cs 48");
                Console.WriteLine($"Tagsize: {songHeader.TagSize}");

                // Add header to MP3info var
                songWrapper.Header = songHeader;

                // request further bytes from data layer
                bytes = data.LoadBytes(fileName, songHeader.TagSize + 10);

                // return object
                return songWrapper;
            } catch (ArgumentException ae)
            {
                Console.WriteLine($"{ae.Message}");
            }

            return new MP3info();
        }

        private int CalculateID3TagSize(byte[] array)
        {
            // initialize variable
            int totalSize = 0;

            for(int i = 0; i < 4; i++)
            {
                totalSize += array[3 - i] << 7 * i;
            }

            return totalSize;
        }

        private void WriteBytes(List<byte> bytes)
        {
            int counter = 0;
            foreach (byte b in bytes)
            {
                if (counter % 10 == 0)
                {
                    Console.WriteLine();
                    Console.Write($" {counter} ");
                }

                Console.Write($"{b:X2} ");

                counter++;
                
            }
        }
    }
}
