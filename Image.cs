using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse
{
    class Image
    {
        public string extensionI = ".bmp";
        public string Name { get; private set; }
        public long Size { get; private set; }
        public string Resolution { get; private set; }
        
        public Image(string name, string size, string resolution)
        {
            Name = name;
            Size = Extensions.ConvertSize(size);
            Resolution = resolution;
        }
    }
}
