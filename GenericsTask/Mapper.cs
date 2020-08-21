using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    internal class Mapper<TSource, TResult>
        where TSource : ISource
        where TResult : IResult
    {
        public TSource Source { get; set; }
        public TResult Result { get; set; }
        public TResult Map3<TSource>(TSource source)
        {
            var result = Activator.CreateInstance<TResult>();

            if (source != null && result != null)
            {
                List<PropertyInfo> sourceProperties = source.GetType().GetProperties().ToList();
                List<PropertyInfo> resultProperties = result.GetType().GetProperties().ToList();

                if (resultProperties != null)
                {
                    foreach (var resultProperty in resultProperties)
                    {
                        PropertyInfo sourceProperty = sourceProperties.Find(x => x.Name == resultProperty.Name);
                        if (sourceProperty != null)
                        {
                            if (sourceProperty.PropertyType == resultProperty.PropertyType)
                            {
                                try
                                {
                                    resultProperty.SetValue(result, sourceProperty.GetValue(source, null), null);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("{0} Exception caught.", e);
                                }
                            }                            
                        }
                    }
                }
            }
            return result;
        }     
    }
}
