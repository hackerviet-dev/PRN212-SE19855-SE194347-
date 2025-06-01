using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public static class MyUtils
    {
        /* Câu 1 : cài đặt 1 hàm trong Tongtu1toN
         * vào kiểu int của microsoft
         */
        public static int Tongtu1toN(this int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int Cong(this int a, int b)
        {
            return a + b;
        }
        public static void SapXepTangDan(this int[]arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void TaoMang(this int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100); // Tạo số ngẫu nhiên từ 1 đến 99
            }
        }
        public static void XuatMang(this int[] arr)
        {
           foreach (int i in arr)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
        }
    }
}
