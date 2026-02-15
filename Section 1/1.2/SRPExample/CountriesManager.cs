using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SRPExample
{
    class CountriesManager
    {
        private Country[] _countries;

        public CountriesManager()
        {
            // Sample data (original app used restcountries.eu API which is no longer available)
            _countries = new Country[]
            {
                new Country { Name = "Germany", Capital = "Berlin", Region = "Europe" },
                new Country { Name = "France", Capital = "Paris", Region = "Europe" },
                new Country { Name = "Spain", Capital = "Madrid", Region = "Europe" },
                new Country { Name = "Italy", Capital = "Rome", Region = "Europe" },
                new Country { Name = "United Kingdom", Capital = "London", Region = "Europe" },
                new Country { Name = "Netherlands", Capital = "Amsterdam", Region = "Europe" },
                new Country { Name = "Sweden", Capital = "Stockholm", Region = "Europe" },
                new Country { Name = "Japan", Capital = "Tokyo", Region = "Asia" },
                new Country { Name = "China", Capital = "Beijing", Region = "Asia" },
                new Country { Name = "India", Capital = "New Delhi", Region = "Asia" },
                new Country { Name = "Brazil", Capital = "Brasília", Region = "Americas" },
                new Country { Name = "Nigeria", Capital = "Abuja", Region = "Africa" },
            };
        }

        public Task<Country[]> GetCountries()
        {
            return Task.FromResult(_countries);
        }

        public Task<Country[]> GetEuropeanCountries()
        {
            List<Country> europeanCountries = new List<Country>();
            foreach(var country in _countries)
            {
                if(country.Region == "Europe")
                {
                    europeanCountries.Add(country);
                }
            }
            return Task.FromResult(europeanCountries.ToArray());
        }

        public Task<Country[]> GetAsianCountries()
        {
            List<Country> asianCountries = new List<Country>();
            foreach(var country in _countries)
            {
                if(country.Region == "Asia")
                {
                    asianCountries.Add(country);
                }
            }
            return Task.FromResult(asianCountries.ToArray());
        }
    }
}
