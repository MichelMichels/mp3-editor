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

        /**
         * Fields
         */
        private List<byte> MP3Bytes = new List<byte>();

        public MP3info GetMP3File(string fileName)
        {
            // Create MP3 var
            MP3info songInfo = new MP3info();
            
            // Load header in byte array
            MP3Bytes = data.loadMP3File(fileName, 10);

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

            // DEBUG
            foreach (byte b in MP3Bytes)
            {
                Console.Write($"{b:X2} ");
            }

            // set version
            songInfo.MajorVersion = MP3Bytes[3];
            songInfo.RevisionNumber = MP3Bytes[4];

            // set flags
            songInfo.UnsynchronisationFlag = (MP3Bytes[5] & 0x80) == 0x00 ? false : true;
            songInfo.ExtendedHeaderFlag = (MP3Bytes[5] & 0x40) == 0x00 ? false : true;
            songInfo.ExperimentalIndicatorFlag = (MP3Bytes[5] & 0x20) == 0x00 ? false : true;

            // tag size
            songInfo.TagSize = CalculateID3TagSize(new byte[] { MP3Bytes[6], MP3Bytes[7], MP3Bytes[8], MP3Bytes[9]});

            // request further bytes from data layer
            MP3Bytes = data.loadMP3File(fileName, songInfo.TagSize + 10);

            // debug
            //WriteBytes();

            // return object
            return songInfo;
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

        private void WriteBytes()
        {
            int counter = 0;
            foreach (byte b in MP3Bytes)
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
