using System;

namespace OpenClosedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Country[]
            {
                new Country { Name = "Germany", Capital = "Berlin", Region = "Europe" },
                new Country { Name = "France", Capital = "Paris", Region = "Europe" },
                new Country { Name = "Japan", Capital = "Tokyo", Region = "Asia" },
            };

            // Base formatter (plain text)
            CountryFormatter baseFormatter = new CountryFormatter();
            Console.WriteLine("=== Base Format ===");
            foreach (var country in countries)
            {
                Console.WriteLine(baseFormatter.Format(country));
            }

            // HTML formatter — extends behavior WITHOUT modifying CountryFormatter
            CountryFormatter htmlFormatter = new CountryHTMLFormatter();
            Console.WriteLine();
            Console.WriteLine("=== HTML Format ===");
            foreach (var country in countries)
            {
                Console.WriteLine(htmlFormatter.Format(country));
            }
        }
    }
}
