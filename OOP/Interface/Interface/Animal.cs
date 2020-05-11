using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
	public class Animal:ISpeak
	{
		public void Speak()
		{
			Console.WriteLine("animal is speaking.....");
		}
	}
}
