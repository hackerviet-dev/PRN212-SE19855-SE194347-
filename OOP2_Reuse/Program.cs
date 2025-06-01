using OOP_2;
using OOP2_Reuse;

Console.OutputEncoding = System.Text.Encoding.UTF8;
FulltimeEmployee e1 = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123456789",
    Name = "Con cho",
    Birthday = new DateTime(1990, 12, 9)
};
Console.WriteLine("-----Thong tin cua E1-------");
Console.WriteLine(e1);
Console.WriteLine("===>Age "+e1.TinhTuoi());