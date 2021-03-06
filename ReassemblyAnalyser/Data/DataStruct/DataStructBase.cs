﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReassemblyAnalyser.Data.DataStruct
{
    public abstract class DataStructBase : IDataStruct
    {
        public abstract int Count { get; }
        public abstract bool IsNull { get; }

        public virtual void Dispose() { }

        public abstract IDataStruct Get(object identifier);

        public abstract object GetValue(object identifier);

        public IEnumerator GetEnumerator()
        {
            return new DataStructEnumerator(this);
        }

        public abstract string Serialize();

    }
}
