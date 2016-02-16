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
        // ------
        // EVENTS
        // ------
        //public event Action<int> BytesLoaded = (int count) => { };

        // -------
        // METHODS
        // -------
        public byte[] GetID3TagBytes(string fileName, int numberOfBytes)
        {
            // Array to store read bytes
            byte[] bytes = new byte[numberOfBytes];

            using (var file = new BinaryReader(File.OpenRead(fileName)))
            {
                // Read number of bytes
                bytes = file.ReadBytes(numberOfBytes);
            }

            // return the array
            return bytes;
        }

        public void WriteID3Tag(string fileName, byte[] bytes)
        {
            using (var file = new BinaryWriter(File.OpenWrite(fileName)))
            {
                // Set pointer to begin of file
                file.Seek(0, SeekOrigin.Begin);

                // Write bytes
                file.Write(bytes);
            }
        }
    }
}
