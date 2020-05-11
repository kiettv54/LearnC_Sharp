using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SortedList_Csharp
{
	class PersonComparer:IComparer
	{
		public int Compare(object x, object y)
		{
			Person a = x as Person;
			Person b = y as Person;
			if(a == null|| b==null)
			{
				throw new InvalidOperationException();
			}	
			else
			{
				if (a.Age < b.Age)
				{
					return 1;
				}
				else
					if (a.Age == b.Age)
				{
					return 0;
				}
				else
				{
					return -1;
				}	
			}	
		}
	}
}
