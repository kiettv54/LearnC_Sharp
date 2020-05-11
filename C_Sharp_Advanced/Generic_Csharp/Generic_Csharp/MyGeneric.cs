using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Csharp
{
	public class MyGeneric<T>
	{
		private T[] items;

		public T[] Items { get => items; set => items = value; }
		public MyGeneric(int size)
		{
			items = new T[size];
		}
		public T getByIndex(int index)
		{
			if(index<0 || index > items.Length)
			{
				throw new InvalidOperationException();
			}	
			else
			{
				return items[index];
			}	

		}
		public void setItemValue(int index,T value)
		{
			if (index < 0 || index > items.Length)
			{
				throw new InvalidOperationException();
			}
			else
			{
				items[index] = value;
			}
		}
	}
}
