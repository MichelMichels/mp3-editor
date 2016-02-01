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
        public event Action<int> BytesLoaded = (int count) => { };

        // -------
        // METHODS
        // -------
        public List<byte> LoadBytes(string fileName, int numberOfBytes)
        {
            // Array to store read bytes
            List<byte> bytes = new List<byte>();

            using (var file = File.Open(fileName, FileMode.Open))
            {
                // Set pointer
                file.Seek(0, SeekOrigin.Begin);
                
                // Read number of bytes
                int i = 0;
                while( i < numberOfBytes)
                {
                    bytes.Add((byte)file.ReadByte());
                    i++;
                }
                
                // DEBUG
                BytesLoaded(numberOfBytes);
            }

            // return the array
            return bytes;
        }
    }
}
