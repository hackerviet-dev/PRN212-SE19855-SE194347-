using OOP_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123456789",
    Name = "Barack Obama",
    Birthday = new DateTime(1961, 8, 4)

};
Console.WriteLine("=========================");
Console.WriteLine($"Id = {obama.Id}");
Console.WriteLine($"IdCard = {obama.IdCard}");
Console.WriteLine($"Name = {obama.Name}");
Console.WriteLine($"Birthday = {obama.Birthday.ToShortDateString()}");
Console.WriteLine($"Salary = {obama.calSalary()}");
/////////////////////////////////////////////////
PartTimeEmployee trump = new PartTimeEmployee()
{
    Id = 2,
    IdCard = "987654321",
    Name = "Donald Trump",
    Birthday = new DateTime(1946, 6, 14),
    WorkingHours = 3 // Số giờ làm việc
};
Console.WriteLine("=========================");
Console.WriteLine($"Id = {trump.Id}");
Console.WriteLine($"IdCard = {trump.IdCard}");
Console.WriteLine($"Name = {trump.Name}");
Console.WriteLine($"Birthday = {trump.Birthday.ToShortDateString()}");
Console.WriteLine($"Salary = {trump.calSalary()}");
Console.WriteLine($"WorkingHours = {trump.WorkingHours}");

Console.WriteLine("-----------Su dung tostring---------------");
Console.WriteLine(obama); // Tự động gọi ToString() của FulltimeEmployee
Console.WriteLine(trump); // Tự động gọi ToString() của PartTimeEmployee
