using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    class AClass : ISource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public List<string> ListOfA { get; set; }
        public List<string> List1 { get; set; }
        public void PrintValues(List<string> list)
        {
            Console.WriteLine("Values: {0}", String.Join(",", list));
        }
        public string ReturnName(string name)
        {
            return name;
        }
    }
}
