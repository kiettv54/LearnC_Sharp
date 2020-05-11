using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HocToantu
{
  public  class NgayThang
    {
        public int ngay, thang, nam,tong;
     public  void Nhap()
        {
            Console.Write("Enter day:");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Enter Month:");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Enter year:");
            nam = int.Parse(Console.ReadLine());
            tong = ngay + thang + nam;
        }
     public void xuat()
        {
            Console.WriteLine("Ngay Sinh:{0}-{1}-{2}", ngay, thang, nam);
            Console.WriteLine("Ham bam la:{0}", bam(tong));
        }
        public string bam(int chuoi)
        {
            
            string xuly = Convert.ToString(chuoi);

            byte[] tem = ASCIIEncoding.ASCII.GetBytes(xuly);
            byte[] hashdata = new  MD5CryptoServiceProvider().ComputeHash(tem);
            string hashtong = "";
            foreach  (byte item in hashdata)
            {
                hashtong += item;
            }
            return hashtong;
        }
    }
}
