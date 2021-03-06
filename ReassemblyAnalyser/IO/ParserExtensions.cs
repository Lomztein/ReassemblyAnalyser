﻿using ReassemblyAnalyser.Data.DataStruct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReassemblyAnalyser.IO
{
    public static class ParserExtensions
    {
        public static IDataStruct FromFile (this IDataParser parser, string path)
        {
            return parser.FromString(File.ReadAllText(path));
        }
    }
}
