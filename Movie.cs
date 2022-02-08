using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse
{
    class Movie
    {
        public string extensionM = ".mkv";
        public string Name { get; private set; }
        public long Size { get; private set; }
        public string Resolution { get; private set; }
        public string MovieLength { get; private set; }
        
        public Movie(string name, string size, string resolution, string length)
        {
            Name = name;
            Size = Extensions.ConvertSize(size);
            Resolution = resolution;
            MovieLength = length;
        }
    }
    
}
