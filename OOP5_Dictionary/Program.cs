using OOP5_Dictionary;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc duong";
 Product p1 = new Product();
p1.Id = 1;
p1.Name = "Tra Da";
p1.Quantity = 10;
p1.Price = 15;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "TRa Sua";
p2.Quantity = 30;
p2.Price = 15;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "TRa Dau";
p3.Quantity = 7;
p3.Price = 20;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "TRa Xoai";
p4.Quantity = 4;
p4.Price = 25;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "TRa Oi";
p5.Quantity = 8;
p5.Price = 20;
c1.AddProduct(p5);

//xuat toan bo san pham cua danh muc
Console.WriteLine("------Toan bo san pham cua nuoc----------");
c1.PrintAllProduct();

Dictionary<int, Product> filters = c1.FilterProductsByPrice(10, 20);
Console.WriteLine("---Cac san pham co gia tu 10 den 20-----");
foreach (KeyValuePair<int, Product> kvp in filters)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}
Dictionary<int, Product> sort_resutlt = c1.SortProductByPrice();
Console.WriteLine("---Cac san pham sau khi sap xep-----");
foreach (KeyValuePair<int, Product> kvp in sort_resutlt)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_complex = c1.ComplexSort();
Console.WriteLine("---Cac san pham sau khi sap xep Complex-----");
foreach (KeyValuePair<int, Product> kvp in sort_complex)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}
p1.Name = "Xa xi";
p1.Quantity = 10;
p1.Price = 20;
c1.UpdateProduct(p1);
Console.WriteLine("-----San pham sau khi chinh sua-------");
c1.PrintAllProduct();

int id = 3;
bool ret = c1.DeleteProduct(id);
if (ret)
{
    Console.WriteLine($"Da xoa san pham co ma {id} thanh con");
    Console.WriteLine("---------San pham sau khi xoa----------");
    c1.PrintAllProduct();
}
else
{
    Console.WriteLine($"KO tim thay san pham co ma {id} de xoa");
}

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia";
c2.AddProduct(new Product() { Id = 6, Name = "Sai gon", Quantity = 10, Price = 120 });
c2.AddProduct(new Product() { Id = 7, Name = "333", Quantity = 15, Price = 1200 });
c2.AddProduct(new Product() { Id = 8, Name = "Heniken", Quantity = 20, Price = 140 });
LinkedList<Category> ss = new LinkedList<Category>();
ss.AddLast(c1);
ss.AddLast(c2);
Console.WriteLine("-------toan bo du lieu tu danh muc------------");
foreach (Category c in ss)
{
    Console.WriteLine($"---{c.Name}");
    Console.WriteLine("-------------------");
    c.PrintAllProduct();
    Console.WriteLine("--------------------");
}