using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpBasics
{
    class Homework_1
    {
        public void Task_01()
        {
            int a = 5;
            double b = 5.25;
            char c = 'a';
            bool d = true;
            string my_name = "Nadzeya";
            Console.WriteLine($"a={a}\nb={b}\nc={c}\nd={d}\nmy_name={my_name}");


        }
        public void Task_02()
        {
            Console.WriteLine("Enter you name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            var surname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            var age = Console.ReadLine();
            Console.WriteLine($"How old are you?', - policemen asked.");
            Console.WriteLine($"'{age}', - {name} {surname} answered");

        }
        public void Task_03()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter surname");
            var surname = Console.ReadLine();
            Console.WriteLine("Enter job title");
            var job_title = Console.ReadLine();
            Console.WriteLine("Enter qualification");
            var qualification = Console.ReadLine();
            Console.WriteLine(string.Join(" ", name, surname, job_title, qualification));
            Console.WriteLine(String.Concat(name, " ", surname, " ", job_title, " ", qualification));
        }
        public void Task_04()
        {
            Console.WriteLine("Please enter string");
            string enteredString = Console.ReadLine();
            int length = enteredString.Length - 1;
            string modification_1 = enteredString.Substring(2, length - 1);
            Console.WriteLine(modification_1);// Output a string from the 3rd character for clarity and verification of the result
            string modification_2 = enteredString.Substring(0, 2);
            Console.WriteLine(modification_2);// Output a string the 3rd character for clarity and verification of the result
            Console.WriteLine(string.Join("", modification_2, modification_1));

        }
        public void Task_05()
        {
            Console.WriteLine("Please enter a poem");
            var poem = Console.ReadLine();
            Console.WriteLine("Please enter the adjective to replace");
            var adjective_ToReplase = Console.ReadLine();
            Console.WriteLine("Please enter the adjective of opposite meaning");
            var opposite_adjective = Console.ReadLine();
            Console.WriteLine(poem.Replace(adjective_ToReplase, opposite_adjective));
        }
        public void Task_06()
        {
            Console.WriteLine("Please enter a lower case letter");
            string lowerCaseLetter = Console.ReadLine();
            string upperCaseLetter = lowerCaseLetter.ToUpper();
            Console.WriteLine("The letter in upper case is " + upperCaseLetter);

        }

        public void Task_07()
        {
            Console.WriteLine("Please enter a string 1");
            string str_1 = Console.ReadLine();
            Console.WriteLine("Please enter a string 2");
            string str_2 = Console.ReadLine();
            Console.WriteLine("Please enter a string 3");
            string str_3 = Console.ReadLine();
            Console.WriteLine("Please enter a sring 4");
            string str_4 = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendJoin(" ", str_1, str_2, str_3, str_4);
            Console.WriteLine(sb.ToString());

        }
    }

}
