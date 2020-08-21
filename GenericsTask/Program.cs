using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            AClass a = new AClass()
            {
                Id = 1,
                Name = "asia",
                Value = "someString",
                List1 = new List<string>(){ "aa", "aa"}
            };
            BClass b = new BClass()
            {
                Id = 2,
                Name = "basia",
                Value = 8,
                List1 = new List<string>(){ "op", "kl", "nm" }
            };
            Console.WriteLine("Before map:");
            Console.WriteLine("a.Id: {0}", a.Id);
            Console.WriteLine("a.Name: {0}", a.Name);
            Console.WriteLine("a.Value: {0}", a.Value);
            Console.WriteLine("a.List1: {0}", String.Join(",", a.List1));

            Console.WriteLine("b.Id: {0}", b.Id);
            Console.WriteLine("b.Name: {0}", b.Name);
            Console.WriteLine("b.Value: {0}", b.Value);
            Console.WriteLine("b.List1: {0}", String.Join(",", b.List1));

            var mapper2 = new Mapper<AClass, BClass>();
            mapper2.Source = a;
            mapper2.Result = mapper2.Map3(a);

            Console.WriteLine();
            Console.WriteLine("After map:");

            Console.WriteLine("mapper2.Result.Id: {0}", mapper2.Result.Id);
            Console.WriteLine("mapper2.Result.Name: {0}", mapper2.Result.Name);
            Console.WriteLine("mapper2.Result.Value: {0}", mapper2.Result.Value);
            Console.WriteLine("mapper2.Result.List1: {0}", String.Join(",", mapper2.Result.List1));

            Console.WriteLine("mapper2.Source.Id: {0}", mapper2.Source.Id);
            Console.WriteLine("mapper2.Source.Name: {0}", mapper2.Source.Name);
            Console.WriteLine("mapper2.Source.Value: {0}", mapper2.Source.Value);
            Console.WriteLine("mapper2.Source.List1: {0}", String.Join(",", mapper2.Source.List1));

            Console.ReadKey();
        }
    }
}
