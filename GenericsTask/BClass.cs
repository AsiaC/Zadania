using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    class BClass : IResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public List<string> ListOfB { get; set; }
        public List<string> List1 { get; set; }
        public void PrintCountOfElements(List<String>list)
        {
            Console.WriteLine("Count of elements: {0}", list.Count);
        }
        public string ReturnName(string name)
        {
            return name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
    }
}
