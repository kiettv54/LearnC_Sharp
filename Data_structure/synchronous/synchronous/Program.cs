using System;
using System.Dynamic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace synchronous
{
    class Program
    {
        public static string DownloadWebpage(string url, bool showresult)
        {
            using (var client = new WebClient())
            {
                Console.Write("Starting download ...");
                string content = client.DownloadString(url);
                Thread.Sleep(3000);
                if (showresult)
                    Console.WriteLine(content.Substring(0, 150));

                return content;
            }
        }
        static void Main(string[] args)
        {
            //Đồng bộ
            //string url = "https://code.visualstudio.com/";
            //DownloadWebpage(url, true);
            //Console.WriteLine("Do somthing ...");
            //split string
            //string k = "1234567890";
            ////Console.WriteLine(k.Substring(0,3));
            ///
            Console.WriteLine($"{' ',5} {Thread.CurrentThread.ManagedThreadId,3} MainThread");
            Task<string> t1 = TestAsync01.Async1("A", "B");
            Task t2 = TestAsync01.Async2();

            Console.WriteLine("Làm gì đó ở thread chính sau khi 2 task chạy");

            // Chờ t1 kết thúc và đọc kết quả trả về
            t1.Wait();
            String s = t1.Result;
            TestAsync01.WriteLine(s, ConsoleColor.Red);

            // Ngăn không cho thread chính kết thúc
            // Nếu thread chính kết thúc mà t2 đang chạy nó sẽ bị ngắt
            Console.ReadLine();
            
        }
    }
}
