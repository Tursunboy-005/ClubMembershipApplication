﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_01
{
    public class DALException : Exception
    {
        public DALException() { }

        public DALException(string message) : base(message) { }

        public DALException(string message, Exception inner) : base(message, inner) { }
    }
}
