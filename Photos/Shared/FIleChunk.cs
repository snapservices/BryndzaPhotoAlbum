using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photos.Shared
{
    public class FileChunk
    {
        public string FileNameNoPath { get; set; } = "";
        public long Offset { get; set; }
        public byte[] Data { get; set; } 
        public bool FirstChunk = false;
    }
}
