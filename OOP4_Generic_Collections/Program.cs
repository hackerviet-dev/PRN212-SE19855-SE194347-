using OOP_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
/* Su dung generics de tao ra list de quan ly nhan vien
 * thuc hien day du tinh nang CRUD
 */
// Cau 1 - Create a list of employees
// Dung list de tao 5 employee, trong do 4 employee la fulltime, 1 employee la parttime
List<Employee> employees = new List<Employee>();
FulltimeEmployee e1 = new FulltimeEmployee();
{
    e1.Id = 1;
    e1.IdCard = "123456789";
    e1.Name = "Con ca";
    e1.Birthday = new DateTime(2020, 12, 9);
    employees.Add(e1);
}
FulltimeEmployee e2 = new FulltimeEmployee();
{
    e2.Id = 2;
    e2.IdCard = "123456789";
    e2.Name = "Con ca sau";
    e2.Birthday = new DateTime(2005, 12, 9);
    employees.Add(e2);
}
FulltimeEmployee e3 = new FulltimeEmployee();
{
    e3.Id = 3;
    e3.IdCard = "123456789";
    e3.Name = "Con chuot";
    e3.Birthday = new DateTime(1990, 12, 9);
    employees.Add(e3);
}
FulltimeEmployee e4 = new FulltimeEmployee();
{
    e4.Id = 4;
    e4.IdCard = "123456789";
    e4.Name = "Con meo";
    e4.Birthday = new DateTime(1999, 12, 9);
    employees.Add(e4);
}
PartTimeEmployee e5 = new PartTimeEmployee();
{
    e5.Id = 5;
    e5.IdCard = "123456789";
    e5.Name = "Con puddle";
    e5.Birthday = new DateTime(2023, 12, 9);
    employees.Add(e5);
}
//cau 2: Read all employees
//cach 1
Console.WriteLine("-----Danh sach nhan su-----------");
employees.ForEach(e => Console.WriteLine(e));
//cach 2
Console.WriteLine("-----Danh sach nhan su cach 2-----------");
foreach (var emp in employees)
{
    Console.WriteLine(emp);
}
//cau 3: R --> loc ra nhan su chinh thuc va tinh tong luong
// Cach 1 Loc nhan su fulltime
List<FulltimeEmployee> fullTimeEmployees = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("-----Danh sach nhan su fulltime-----------");
fullTimeEmployees.ForEach(e => Console.WriteLine(e));
// Cach 2 dung cach thong thuong
List<Employee> fullTimeEmployees2 = new List<Employee>();
foreach (var e in employees)
{
    if (e is FulltimeEmployee)
    {
        fullTimeEmployees2.Add(e as FulltimeEmployee);
    }
}
Console.WriteLine("-----Danh sach nhan su fulltime cach 2-----------");
fullTimeEmployees2.ForEach(e => Console.WriteLine(e));
// tong luong :
double sumSalary = fullTimeEmployees.Sum(e => e.calSalary());
Console.WriteLine("Tong luong nhan vien fulltime: " + sumSalary);
//cau 4 : xap xep nhan su theo ngay thang nam sinh
for (int i = 0; i < employees.Count ; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        Employee employeei = employees[i];
        Employee employeej = employees[j];
        if (employeei.Birthday > employeej.Birthday)
        {
            // Hoan doi vi tri
            employees[i] = employeej;
            employees[j] = employeei;
        }
    }
}
Console.WriteLine("-----Danh sach nhan su sap xep theo ngay thang nam sinh-----------");
employees.ForEach(e => Console.WriteLine(e));