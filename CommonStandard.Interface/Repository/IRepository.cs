using System;
using System.Collections.Generic;
using System.Text;

namespace CommonStandard.Interface.Repository
{
    public interface IRepository<TOut, TIn>
    {
        TOut Get(TIn key);
        bool Set(TIn key, TOut value);
    }
}
