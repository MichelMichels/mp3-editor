using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class ID3Frame
    {
        // Fields
        private int _offset;
        private string _id;
        private int _size;
        private byte[] _flags;
        private byte[] _data;
        
        // byte offset
        public int Offset { get; set; }

        public string ID { get; set; }
        // frame size - header size = frame size - 10
        public int Size { get; set; }
        public byte[] Flags { get; set; }

        public byte[] Data { get; set; }

        private string GetDataString()
        {
            char[] c = new char[Data.Length - 1];

            for (int i = 0; i < Data.Length - 1; i++)
            {
                c[i] = (char)Data[i+1];
            }

            return new string(c);
        }

        public void PrintDataBytes()
        {
            foreach(byte b in Data)
            {
                Console.Write($"{b:X2} ");
            }

            Console.WriteLine();
        } 

        public override string ToString()
        {
            string d = GetDataString();

            return $"{ID} {d}";
        }
    }
}
