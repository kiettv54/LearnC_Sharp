using System;
using System.Collections.Generic;

namespace Dictionnary_hash
{
    class person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Class { get; set; }
        public int age { get; set; }
        public person() { }
        public person(int id,string name,string Class,int age)
        {
            this.id = id;
            this.name = name;
            this.Class = Class;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<person> ps = new List<person>() 
            {
                new person(1, "kiet", "Da17TT", 21) ,
                new person(2,"Tai","Da17TT",22),
                new person(3,"Duy","Da17TT",20)
                
            };
            Dictionary<int, person> data = new Dictionary<int, person>();
            foreach(person p in ps)
            {
                data.Add(p.id, p);
            }
            var keys = data.Keys;
            foreach (var k in keys)
            {
                var value = data[k];
                Console.WriteLine($"{k} = {value.id+value.name+value.Class+value.age}");
            }

            Console.ReadLine();
        }
    }
}
