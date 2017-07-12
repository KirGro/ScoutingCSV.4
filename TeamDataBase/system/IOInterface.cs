using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDataBase
{
    class IOInterface
    {
        Dictionary<String, FileStream> FileStreams = new Dictionary<String, FileStream>();

        internal IOInterface()
        {
            StreamReader sr = new StreamReader(new FileStream("",FileMode.OpenOrCreate));
            sr.ReadLine();
        }

        public bool startFileStream(String path, String key)
        {
            FileStreams.Add(key, new FileStream(path, FileMode.OpenOrCreate));
            return true;
        }

        public FileStream getFileStream(String key)
        {
            FileStream var;
            if (FileStreams.TryGetValue(key, out var))
            {
                return var;
            }
            else return null;
        }
    }
}
