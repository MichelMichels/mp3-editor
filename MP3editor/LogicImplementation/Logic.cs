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
        /**
         * Data handling var
         */
        DataHandler data = new DataHandler();
        
        /**
         * Constants
         */
        private const int HEADER_LENGTH = 10;
        private const int FRAME_HEADER_LENGTH = 10;

        /**
         * Methods
         */
        public ID3Tag GetID3Tag(string fileName)
        {
            // Create ID3 tag var
            var tag = new ID3Tag();

            // Check ID3 identifier
            tag.Bytes = data.GetID3TagBytes(fileName, 3);
            if(!tag.HasID3Identifier())
            {
                return new ID3Tag();
            }

            // Load Header bytes into Tag (10 bytes)
            tag.Bytes = data.GetID3TagBytes(fileName, HEADER_LENGTH);
            tag.Header = new ID3Header(tag.Bytes);

            // Load Header + All frames
            tag.Bytes = data.GetID3TagBytes(fileName, HEADER_LENGTH + tag.Header.TagSize);

            if(tag.Header.ExtendedHeaderFlag)
            {
                Console.WriteLine($"DEBUG Extended Header detected. Not implemented.");
            }

            // Load frames
            tag.Frames = GetID3Frames(tag.Bytes);

            // Return the created tag
            return tag; 
        }

        private void DebugWriteBytes(byte[] bytes)
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

        private ID3Frame GetID3Frame(byte[] bytes, int start)
        {
            // Create a local var
            var frame = new ID3Frame();
            frame.Offset = start;

            // Get ID
            char[] c = { (char)bytes[start], (char)bytes[start + 1], (char)bytes[start + 2], (char)bytes[start + 3] };
            frame.ID = new string(c);

            // Check if tag hasn't ended
            if(frame.ID == "\0\0\0\0")
            {
                return new ID3Frame();
            }

            // Calculate frame size and add to frame var
            frame.Size = 0;

            for (int i = 0; i < 4; i++)
            {
                frame.Size += bytes[start + 4 + i] << 8 * (3 - i);
            }

            // Get data in an array
            byte[] data = new byte[frame.Size];
            for (int i = 0; i < frame.Size; i++)
            {
                data[i] = bytes[start + 10 + i];
            }

            // Add data array to frame var
            frame.Data = data;

            // Return frame
            return frame;
        }

        private List<ID3Frame> GetID3Frames(byte[] bytes)
        {
            // Create a List var
            var frames = new List<ID3Frame>();

            // Save offset
            int offset = HEADER_LENGTH;
            while (offset < bytes.Length)
            {
                ID3Frame frame = GetID3Frame(bytes, offset);
                if (frame.Size == 0) break;

                frames.Add(frame);
                offset += FRAME_HEADER_LENGTH + frame.Size;
            }
            return frames;
        }
    }
}
