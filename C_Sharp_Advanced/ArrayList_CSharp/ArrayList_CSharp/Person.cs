using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_CSharp
{
	class Person
	{
		private string name;
		private int age;
		public Person() { }
		public Person(string name,int age)
		{
			this.Name = name;
			this.Age = age;
		}
		public override string ToString()
		{
			return "Name:" + name + "| Age:" + age;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
	}
}
