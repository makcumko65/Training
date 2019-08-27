using System;
using System.Collections.Generic;

namespace Training3
{
    static class Program
    {
        static void Main(string[] args)
        {
            //##############################TASK1############################
            Console.WriteLine("##############################TASK1############################");
            List<Person> persons = new List<Person>() {
                new Person{Name = "Tom", Age = 23, PhoneNumbers = new List<string>(){
                    "380965493842",
                    "380545493841"
                }
                },
                new Person{Name = "Tom", Age = 23, PhoneNumbers = new List<string>(){
                    "380965493842",
                    "380545493841"
                } },
                new Person{Name = "John", Age = 23, PhoneNumbers = new List<string>(){
                    "380965493842",
                    "380545493841"
                }
                },
                new Person{Name = "Tom", Age = 10, PhoneNumbers = new List<string>(){
                    "380965493842",
                    "380545493841"
                }
                },
                new Person{Name = "Tom", Age = 23, PhoneNumbers = new List<string>(){
                    "380965493842",
                    "380545493841"
                }
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            //##############################TASK2############################
            Console.WriteLine("##############################TASK2############################");
            List<Person> persons2 = new List<Person>() {
                new Person{Name = "Dwayne", Age = 23, PhoneNumbers = new List<string>(){
                    "380965493842",
                    "380545493841"
                }
                },
                new Person{Name = "Jack", Age = 23, PhoneNumbers = new List<string>(){
                    "380965493842",
                    "380545493841"
                } },
            };
            persons.AddRange(persons2);
            foreach (var person in persons)
            {
                foreach (var item in person.GetPhoneNumbers())
                {
                    Console.WriteLine(item);
                }
            }
            //##############################TASK3############################
            Console.WriteLine("##############################TASK3############################");
            List<string> letters = new List<string>();
            const string AllowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rng = new Random();
            foreach (string randomString in rng.NextStrings(AllowedChars, (4, 4), 100))
            {
                letters.Add(randomString);
            }
            Console.WriteLine($"LENGTH UNTILL CHANGING = {letters.Count}");
            DeleteFirstZ(letters);
            letters.Sort();
            letters.Reverse();
            Console.WriteLine($"LENGTH AFTER CHANGING = {letters.Count}");
            Console.Write("Enter number: ");
            if (Int32.TryParse(Console.ReadLine(), out int number))
            {
                letters.DisplayPage(number);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            //foreach (var item in letters)
            //{
            //    Console.WriteLine(item);
            //}
            Console.Read();
        }
        private static IEnumerable<string> NextStrings(
            this Random rnd,
            string allowedChars,
            (int Min, int Max) length,
            int count)
        {
            ISet<string> usedRandomStrings = new HashSet<string>();
            (int min, int max) = length;
            char[] chars = new char[max];
            int setLength = allowedChars.Length;

            while (count-- > 0)
            {
                int stringLength = rnd.Next(min, max + 1);

                for (int i = 0; i < stringLength; ++i)
                {
                    chars[i] = allowedChars[rnd.Next(setLength)];
                }

                string randomString = new string(chars, 0, stringLength);

                if (usedRandomStrings.Add(randomString))
                {
                    yield return randomString;
                }
                else
                {
                    count++;
                }
            }
        }
        private static void DeleteFirstZ(List<string> letters)
        {
            for (int i = 0; i < letters.Count; i++)
            {
                if (letters[i][0] == 'Z')
                {
                    letters.RemoveAt(i);
                }
            }
        }
        private static void DisplayPage(this List<string> letters, int page)
        {
            const int ELEMENTS = 5;
            for (int i = page * ELEMENTS - 5; i < page * ELEMENTS; i++)
            {
                Console.Write($"{letters[i]} ");
            }
        }
    }
}
