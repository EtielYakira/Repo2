using System;
using HtmlAgilityPack;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using asdasd;
using System.Text.RegularExpressions;
using System.Collections;

namespace MyNamespace
{


    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    class Program
    {
        
        public static void Main(string[] args)
        {
            var col = new List<Person>()
            {
                new Person("John", 22),
                new Person("Ary", 11),
                new Person("John", 55),
                new Person("John", 66),
                new Person("Ary", 33),
                new Person("John", 77),
                new Person("John", 88)
            };

            var oN = col.GroupBy(person => person.Name);
            foreach (var item in oN)
            {
                foreach (var person in item)
                {
                    Console.WriteLine($"name: {person.Name} Age: {person.Age}");
                }
                System.Console.WriteLine("....................");
                System.Console.WriteLine("hello world");
            }


        }



    }

}



