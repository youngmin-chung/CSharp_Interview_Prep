using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AwaitAsyncDeepDive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            var results = new List<T>();

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    results.Add(item);
                }
            }
            return results;
        }


        public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
}


