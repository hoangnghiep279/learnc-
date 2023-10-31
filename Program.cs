using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1
            //string i = Console.ReadLine();
            //  Console.WriteLine(i);
            /*1.2
              int n = System.Int32.Parse(Console.ReadLine());
              if(n%2==1)
              {
                 if(n%3==0)
                  {
                      Console.WriteLine("day la so le chia het cho 3");
                  }
                 else
                  {
                      Console.WriteLine("day la so le khong chia het cho 3");
                  }
              }
              else
              {
                  if (n % 3 == 0)
                  {
                      Console.WriteLine("day la so chan chia het cho 3");
                  }
                  else
                  {
                      Console.WriteLine("day la so chan khong chia het cho 3");
                  }
              }*/
            /*1.3*/
            //int n = System.Int32.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{

            //    Console.WriteLine("nhap cac phan tu ");
            //}
            int a,b,c,d;
            Console.WriteLine("nhap a");
            a= System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap b");
            b = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap c");
            c = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap d");
            d = System.Int32.Parse(Console.ReadLine());
            if (a == b &&  b == c&&c==d&&d==a)
            {
                Console.WriteLine("khong co thang nào nho nhat");
            } 
            else 
            {
                if (a < b && a < c && a < d)
                {
                    Console.WriteLine("tao la thang a nho nhat:"+ a);
                }
                else if (b < a && a < c && a < d)
                {
                    Console.WriteLine("tao la thang b nho nhat:"+ b);
                }
                else if (c < a && c < b && a < d)
                {
                    Console.WriteLine("tao la thang c nho nhat:"+ c);
                }
                else if (d < b && d < c && d < a)
                {
                    Console.WriteLine("tao la thang d nho nhat:"+d);
                }
            }





        }
    }
}

 