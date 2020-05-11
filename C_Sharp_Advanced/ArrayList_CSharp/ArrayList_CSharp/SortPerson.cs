using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_CSharp
{
	class SortPerson:IComparer
	{
		public int Compare(object x,object y)
		{
			Person p1 = x as Person;
			Person p2 = y as Person;
			if(p1 == null || p2 == null)
			{
				throw new InvalidOperationException();
			}
			else
			/*
			 thục hiện so sánh trả về 1 0 -1 tương ứng bé hơn,bằng,lớn hơn
			 sắp xếp giảm dần

			sắp xếp tăng dần thì so sánh trả về -1 0 1 tương ứng bé hơn,bằng,lớn hơn
			 */
			{
				if (p1.Age < p2.Age)
				{
					return 1;
				}
				else
				if (p1.Age == p2.Age)
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
