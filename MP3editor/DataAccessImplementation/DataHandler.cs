using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessInterface;
using System.IO;

namespace DataAccessImplementation
{
    public class DataHandler : IDataHandler
    {
        public List<byte> loadMP3File(string fileName, int numberOfBytes)
        {
            // Array to store read bytes
            List<byte> mp3Header = new List<byte>();

            using (var file = File.Open(fileName, FileMode.Open))
            {
                // Set pointer
                file.Seek(0, SeekOrigin.Begin);
                   
                // Read number of bytes
                for(int i = 0; i < numberOfBytes; i++)
                {
                    mp3Header.Add((byte) file.ReadByte());
                }
            }

            // return the array
            return mp3Header;
        }
    }
}
