using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class Citizen
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void FilterAndSortVoters(string searchAddress, out List<Citizen> eligibleVoters)
        {
            // Create a list of residents
            List<Citizen> citizens = new List<Citizen>();

            // Filtering the list of residents by address and age
            eligibleVoters = citizens.FindAll(c => c.Address == searchAddress && IsAdult(c.DateOfBirth));

            // Sort the list of voters alphabetically
            eligibleVoters.Sort((c1, c2) => string.Compare(c1.FullName, c2.FullName));
        }
        public bool IsAdult(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age))
                age--;
            return age >= 18;
        }

        public void PrintVoter(string searchAddress, List<Citizen> eligibleVoters)
        {
            foreach (Citizen voter in eligibleVoters)
            {
                Console.WriteLine(voter.FullName);
            }
        }
    }
}