using OOP_3;

Console.OutputEncoding = System.Text.Encoding.UTF8;
int n1 = 5;
Console.WriteLine($"Tổng từ 1 đến 5 là: " +n1.Tongtu1toN()); // Sử dụng phương thức mở rộng
int n2 = 10;
Console.WriteLine("Tổng từ 1 đến 10 là: " + n2.Tongtu1toN()); // Sử dụng phương thức mở rộng
Console.WriteLine("Tong tu 1 den 100 la: " + 100.Tongtu1toN()); // Sử dụng phương thức mở rộng với số nguyên trực tiếp
Console.WriteLine("10+20 = " + 10.Cong(20)); // Sử dụng phương thức mở rộng để cộng hai số nguyên
int[] arr = new int[8];
arr.TaoMang(); // Tạo mảng ngẫu nhiên
Console.WriteLine("Mảng Trước khi sắp xếp");
arr.XuatMang(); // Xuất mảng
arr.SapXepTangDan(); // Sắp xếp mảng tăng dần
Console.WriteLine("Mảng Sau khi sắp xếp tăng dần");
arr.XuatMang(); // Xuất mảng sau khi sắp xếp