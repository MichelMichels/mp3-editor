using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface
{
    public interface IDataHandler
    {
        List<byte> loadMP3File(string fileName, int numberOfBytes);
    }
}
