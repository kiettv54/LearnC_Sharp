using System;
using System.Collections.Generic;
using System.Text;

namespace bt
{
	class Account
	{
		private int id;
		private string name;
		public Account() { }
		public Account(int id , string name)
		{
			this.Id = id;
			this.Name = name;
		}
		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
	}
}
