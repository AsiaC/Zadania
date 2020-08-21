using System;
using System.Collections.Generic;

namespace GenericsTask
{
    public interface IResult
    {
        void PrintCountOfElements(List<String> list);
        string ReturnName(string name);
        void SetName(string name);
    }
}