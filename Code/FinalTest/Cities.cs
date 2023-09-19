using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Cities
    {
        public void CityFiltering()
        {
            List<string> cities = new List<string>()
        {"Minsk", "London", "Colchester", "Paris"};
            char letterToReplaseOn = 'O';

            var filterCities = cities.Where(city => city.Length % 2 == 0)
                .Select(city => city.Replace(city[0], letterToReplaseOn).Substring(0, 3));

            foreach (var city in filterCities)
            { Console.WriteLine(city); }
        }        
    }
}
