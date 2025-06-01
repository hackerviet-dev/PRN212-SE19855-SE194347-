using DemoAliasAndClone;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Student s1 = new Student();
s1.Id = 1;
s1.Name = "Nguyen van a";

Student s2 = new Student();
s2.Id = 2;
s2.Name = "nguyen van tuan";

//luc nay thanh ram se cap phat o nho cho bo xu li
//s1 doi gia tri thi ko lien qua gi s2
//vi s1 va s2 dang quan ly 2 o nho khac nhau

s1 = s2;
//ve ban chat s1 tro toi vung nho s2 dang quan ly chu ko phai s1 bang s2;
//alias la truong hop o nho co tu 2 doi tuong quan ly
//co 2 tinh huong xay
//(1) o nho ben s2 gio co them s1 quan ly => alias
// chi can 1 doi tuong doi thi doi tuong khac cung bi doi
s2.Name = "Nguyen van son";
Console.WriteLine("s2 doi ten gi s1 co doi ten ko");
Console.WriteLine(s1.Name);
//(2) o nho luc truoc dang quan li gio ko con doi tuong nao de quan ly
// thi luc nay co Garbage Collection
// tuc la ko con gia tr s1 co id =1 , name Nguyen Van A

