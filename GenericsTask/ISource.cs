using System;
using System.Collections.Generic;

namespace GenericsTask
{
    public interface ISource
    {
        void PrintValues(List<String> list);
        string ReturnName(string name);
    }
}