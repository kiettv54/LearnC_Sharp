using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ICollecttion_Csharp
{
	class MyArrayList:ICollection
	{
		private object[] Isobject;
		private int count;
		private const int maxcount = 100;
		public MyArrayList()
		{
			count = -1;
			Isobject = new object[maxcount];
		}
		public MyArrayList(int count)
		{
			this.count = count;
			Isobject = new object[count];
		}
		public MyArrayList(Array array)
		{
			array.CopyTo(Isobject, 0);
			count = array.Length;
		}
		public void CopyTo(Array array,int index)
		{
			Isobject.CopyTo(array, index);
		}
	}
}
