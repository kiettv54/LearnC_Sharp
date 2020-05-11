using System;
using System.Collections;

namespace HashTable_Cshap
{
	class Program
	{
		static void Main(string[] args)
		{
			Hashtable hashtable = new Hashtable();
			hashtable.Add("k", 14);
			hashtable.Add("1", 1);
			//thực hiện gán phần tử cho 1 key không tồn tại
			hashtable[2] = 2;
			hashtable[3] = "Ba";

			//trả về một số nguyên số phần tử hiện có
			Console.WriteLine(hashtable.Count);
			/* trả về một danh sách chứa các Key
			foreach (var item in hashtable.Keys)
			{
				Console.WriteLine(item);

			}*/
			/* trả về một danh sách chứa các value
			foreach (var item in hashtable.Values)
			{
				Console.WriteLine(item);

			}*/
			/*
			 duyệt qua các phần tử trong hashtable
			 vì mỗi phần từ là một dictionaryentry nên ta chỉ định kiểu dữ liệu cho item là Dictionaryentry 
			 */
			foreach (DictionaryEntry item in hashtable)
			{
				Console.WriteLine(item.Key+" "+item.Value);

			}
			

		   Console.ReadLine();
		}
	}
}
