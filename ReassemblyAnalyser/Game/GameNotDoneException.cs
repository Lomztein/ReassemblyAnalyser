﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReassemblyAnalyser.Game
{
    public class GameNotDoneException : Exception
    {
        public GameNotDoneException(string message) : base(message) { }
    }
}
