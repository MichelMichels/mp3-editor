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

        // ---------
        // Methods
        // ---------
        public MP3Info GetSongInfo(string fileName)
        {
            // Create MP3 vars
            var songWrapper = new MP3Info();

            // Check if file has an ID3 tag
            var bytes = data.LoadBytes(fileName, 3);
            if (!FileHasID3Tag(bytes))
            {
                Console.WriteLine("DEBUG: Not an ID3 tagged file");
                songWrapper.Header.MajorVersion = 0;
                songWrapper.Header.RevisionNumber = 0;

                // return empty wrapper
                return songWrapper;
            }
            else
            {
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

                // Load header
                bytes = data.LoadBytes(fileName, 10);
                ID3Header songHeader = GetID3Header(bytes);
                songWrapper.Header = songHeader;

                // Request bytes with frames
                bytes = data.LoadBytes(fileName, songHeader.TagSize + 10);
                var songFrames = GetID3Frames(bytes);
                songWrapper.Frames = songFrames;

                // Print frame IDs
                PrintFrames(songWrapper.Frames);

                // return object
                return songWrapper;
            }
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

        private ID3Frame GetID3Frame(List<byte> bytes, int start)
        {
            // Create a local var
            var frame = new ID3Frame();
            frame.Offset = start;

            // Get ID
            char[] c = { (char)bytes[start], (char)bytes[start + 1], (char)bytes[start + 2], (char)bytes[start + 3] };
            frame.ID = new string(c);

            // Calculate frame size
            frame.Size = 0;

            for (int i = 0; i < 4; i++)
            {
                frame.Size += bytes[start + 4 + i] << 8 * (3 - i);
            }

            return frame;
        }

        private ID3Header GetID3Header(List<byte> bytes)
        {
            // Create var
            var songHeader = new ID3Header();
            
            // set version
            songHeader.MajorVersion = bytes[3];
            songHeader.RevisionNumber = bytes[4];

            // set flags
            songHeader.UnsynchronisationFlag = (bytes[5] & 0x80) == 0x00 ? false : true;
            songHeader.ExtendedHeaderFlag = (bytes[5] & 0x40) == 0x00 ? false : true;
            songHeader.ExperimentalIndicatorFlag = (bytes[5] & 0x20) == 0x00 ? false : true;

            // tag size
            songHeader.TagSize = CalculateID3TagSize(new byte[] { bytes[6], bytes[7], bytes[8], bytes[9] });

            // return value
            return songHeader;
        }

        private List<ID3Frame> GetID3Frames(List<byte> bytes)
        {
            // Load all the frames
            var songFrames = new List<ID3Frame>();

            // save offset
            int offset = 10;
            while (offset < bytes.Count)
            {
                ID3Frame frame = GetID3Frame(bytes, offset);
                if (frame.Size == 0) break;

                songFrames.Add(frame);
                offset += frame.Size + 10;
            }

            return songFrames;
        }

        public void PrintFrames(List<ID3Frame> frames)
        {
            foreach(var frame in frames )
            {
                Console.WriteLine($"{frame.ID}");
            }
        }

        private bool FileHasID3Tag(List<byte> bytes)
        {
            // Check if first 3 bytes spell ID3
            if ((char)bytes[0] == 'I' && (char)bytes[1] == 'D' && (char)bytes[2] == '3')
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
