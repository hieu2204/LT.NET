using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap11_9
{
    //internal class BaiTap
    
        class BaiTap
        {
            public void BaiTap1()
            {
                int n;
                Console.Write("Nhap phan tu mang: ");
                n = int.Parse(Console.ReadLine());
                int Sum = 0;
                for(int i =0; i < n; i++)
                {
                    i = int.Parse(Console.ReadLine());
                    Sum += i;
                }
                Console.WriteLine("Tong phan tu mang: " + Sum);
                Console.ReadKey();
            }
            public void BaiTap2()
            {
                string st;
                int cnt = 0;
                Console.Write("Nhap chuoi ki tu: ");
                st = Console.ReadLine();
                //int cnt2 = st.Count(c => char.IsLetterOrDigit(c));
                for (int i = 0; i < st.Length; i++)
                {
                    char c = st[i];
                    if (char.IsLetterOrDigit(c))
                    {
                        cnt++;
                    }
                }
                Console.Write("So luong ki tu trong chuoi: " + cnt);
                //Console.Write("\nSo luong ki trong chuoi: " + cnt2);
                Console.ReadKey();
            }
            public void BaiTap3()
            {
                Console.Write("Nhap so luong phan tu mang: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine("Nhap phan tu mang: ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Mang: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                int Max = arr[0];
                for (int i = 1; i < n; i++)
                {
                    if (arr[i] > Max)
                    {
                        Max = arr[i];
                    }
                }
                Console.Write("\nPhan tu lon nhat mang: " + Max);
                Console.ReadKey();
            }
            public void BaiTap4()
            {
                string a = " ";
                Console.Write("Nhap chuoi: ");
                string st = Console.ReadLine();
                Console.WriteLine("Chuoi: " + st);
                //Console.Write("Chuoi sau khi dao: ");
                //for(int i = st.Length - 1; i >= 0; i--)
                //{
                //    a += st[i];
                //}
                //Console.Write(a);
                char[] arr = st.ToCharArray();
                Array.Reverse(arr);
                string b = new string(arr);
                Console.Write("Chuoi sau khi dao: " + b);
                Console.ReadKey();
            }
            public void BaiTap5()
            {
                int n;
                Console.Write("Nhap so luong phan tu mang: ");
                n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Console.Write("Nhap phan tu mang: ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Mang: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                bool DoiXung = false;
                for (int i = 0; i < n / 2; i++)
                {
                    if (arr[i] == arr[n - i - 1])
                    {
                        DoiXung = true;
                        break;
                    }
                }
                if (DoiXung)
                {
                    Console.Write("\nMang doi xung!");
                }
                else
                {
                    Console.Write("\nMang khong doi xung!");
                }
            }
            public void BaiTap6()
            {
                Console.Write("Nhap chuoi: ");
                string st = Console.ReadLine();
                Console.Write("Nhap ki tu: ");
                char c = char.Parse(Console.ReadLine());
                int cnt = 0;
                for (int i = 0; i < st.Length; i++)
                {
                    if (c == st[i])
                    {
                        cnt++;

                    }
                }
                Console.Write("\nSo lan xuat hien ki tu" + c + ":" + cnt);
                Console.ReadKey();
            }
        }
    }

