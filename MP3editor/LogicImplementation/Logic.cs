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
        private List<byte> MP3Header = new List<byte>();


        public MP3info GetMP3File(string fileName)
        {
            // Create MP3 var
            MP3info songInfo = new MP3info();
            
            // Load header in byte array
            MP3Header = data.loadMP3File(fileName, 10);

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
            foreach (byte b in MP3Header)
            {
                Console.Write($"{b:X2} ");
            }

            // set version
            songInfo.MajorVersion = MP3Header[3];
            songInfo.RevisionNumber = MP3Header[4];

            // set flags
            songInfo.UnsynchronisationFlag = (MP3Header[5] & 0x80) == 0x00 ? false : true;
            songInfo.ExtendedHeaderFlag = (MP3Header[5] & 0x40) == 0x00 ? false : true;
            songInfo.ExperimentalIndicatorFlag = (MP3Header[5] & 0x20) == 0x00 ? false : true;

            // tag size
            songInfo.TagSize = CalculateID3TagSize(new byte[] { MP3Header[6], MP3Header[7], MP3Header[8], MP3Header[9]});

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
    }
}
