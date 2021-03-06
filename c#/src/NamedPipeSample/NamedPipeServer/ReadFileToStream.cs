﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedPipeServer
{
    // Contains the method executed in the context of the impersonated user
    public class ReadFileToStream
    {
        private string fn;
        private StreamString ss;

        public ReadFileToStream(StreamString str, string filename)
        {
            fn = filename;
            ss = str;
        }

        public void Start()
        {
            string contents = File.ReadAllText(fn);
            ss.WriteString(contents);
        }
    }
}
