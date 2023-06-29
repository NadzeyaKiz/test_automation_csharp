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
        string searchAddress;


        public static void Main()
        {

            // Создаем список жителей
            List<Citizen> citizens = new List<Citizen>()
        {
            new Citizen { FullName = "Иванов Иван Иванович", Address = "ул. Первая, 1", DateOfBirth = new DateTime(1980, 1, 1) },
            new Citizen { FullName = "Петров Петр Петрович", Address = "ул. Вторая, 2", DateOfBirth = new DateTime(1995, 5, 10) },
            new Citizen { FullName = "Сидорова Анна Ивановна", Address = "ул. Первая, 1", DateOfBirth = new DateTime(2002, 12, 20) },
            new Citizen { FullName = "Смирнова Елена Петровна", Address = "ул. Третья, 3", DateOfBirth = new DateTime(1988, 9, 5) },
            new Citizen { FullName = "Козлов Константин Алексеевич", Address = "ул. Первая, 1", DateOfBirth = new DateTime(1975, 7, 15) }
        };

            // Заданный адрес для поиска избирателей
            string searchAddress = "ул. Первая, 1";

            // Фильтруем список жителей по адресу и возрасту
            List<Citizen> eligibleVoters = citizens.FindAll(c => c.Address == searchAddress && IsAdult(c.DateOfBirth));

            // Сортируем список избирателей по алфавиту
            eligibleVoters.Sort((c1, c2) => string.Compare(c1.FullName, c2.FullName));
        }
        static bool IsAdult(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age))
                age--;
            return age >= 18;
        }

        public static void PrintVoter()
        {           

            // Выводим информацию о найденных избирателях
            Console.WriteLine("Список избирателей, проживающих по адресу " + searchAddress + ":");
            foreach (Citizen voter in eligibleVoters)
            {
                Console.WriteLine(voter.FullName);
            }
        }
    }