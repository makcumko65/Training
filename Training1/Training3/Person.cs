using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Training3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }

        public IEnumerable GetPhoneNumbers()
        {
            Console.WriteLine(this);
            foreach (var number in PhoneNumbers)
            {
                yield return number;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
}
