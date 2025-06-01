using OOP;
using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Tạo 1 đối tượng danh mục:
Category c1 = new Category();
//Gán giá trị cho các thuộc tính:
c1.Id = 1;
c1.Name = "Nước mắm";
//gọi hàm xuất dữ liệu:
c1.PrintInfor();

//Khởi tạo 1 Nhân viên :
Employee e1 = new Employee();
e1.Id = 1;//gọi setter Property Id
e1.Id_Card = "00123";//gọi setter Property Id_Card
e1.Name = "Tèo";
e1.Email = "teo@gmail.com";
e1.Phone = "0912345678";
//Gọi hàm xuất thông tin:
e1.PrintInfor();
//Ta có thể truy suất theo từng Property để lấy giá trị của thuộc tính:
Console.WriteLine("---------");
Console.WriteLine("Id của e1=" + e1.Id);//gọi getter Property Id
Console.WriteLine($"Name của e1={e1.Name} ");//gọi getter Property Name

//Ta cũng có thể khởi tạo đối tượng và các giá trị của thuộc tính như sau:
Employee e2 = new Employee()
{
    Id = 2,
    Id_Card = "0055",
    Name = "Tý",
    Email = "ty@gmail.com",
    Phone = "0989023456"
};
Console.WriteLine("---E2---");
e2.PrintInfor();

Console.WriteLine("=======================");
Employee e3 = new Employee(3, "0088", "Tám", "tam@gmail.com", "0988888888");
//gọi hàm xuất thông tin:
e3.PrintInfor();
//hoặc tự động gọi tostring() khi đối tượng được xuất ra màn hình:
Console.WriteLine(e3);//tự động hàm ToString()

//thử dùng Constructor mặc định (0 có đối số):
Employee e4 = new Employee();
Console.WriteLine(e4);

//Tạo đối tượng Customer:
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "Nguyễn Thị Lung Linh",
    Email = "lunglinh@hotmail.com",
    Phone = "0999239453",
    Address = "Số 1 Đinh Tiên Hoàng - Quận 1 - HCM"
};
cus1.PrintInfor();
cus1.Address = "Số 2 Đinh Bộ Lĩnh - Bình Thạnh - HCM";
cus1.Phone = "023534546";
Console.WriteLine("Thông tin Customer sau khi chỉnh sửa:");
cus1.PrintInfor();
List<Employee> employees = new List<Employee>();

// Hàm thêm dữ liệu mẫu ban đầu
void SeedEmployees()
{
    employees.Add(new Employee(1, "00123", "Tèo", "teo@gmail.com", "0912345678"));
    employees.Add(new Employee(2, "0055", "Tý", "ty@gmail.com", "0989023456"));
    employees.Add(new Employee(3, "0088", "Tám", "tam@gmail.com", "0988888888"));
}

// Hàm hiển thị danh sách nhân viên
void DisplayEmployees()
{
    Console.WriteLine("\n--- DANH SÁCH NHÂN VIÊN ---");
    foreach (var emp in employees)
    {
        emp.PrintInfor();
    }
}

// Hàm sửa thông tin nhân viên theo ID
void EditEmployee()
{
    Console.Write("Nhập ID nhân viên cần sửa: ");
    int id = int.Parse(Console.ReadLine());
    var emp = employees.FirstOrDefault(e => e.Id == id);
    if (emp != null)
    {
        Console.Write("Tên mới: ");
        emp.Name = Console.ReadLine();
        Console.Write("Email mới: ");
        emp.Email = Console.ReadLine();
        Console.Write("SĐT mới: ");
        emp.Phone = Console.ReadLine();
        Console.WriteLine("Thông tin sau khi cập nhật:");
        emp.PrintInfor();
    }
    else
    {
        Console.WriteLine("❌ Không tìm thấy nhân viên.");
    }
}

// Hàm xóa nhân viên theo ID
void DeleteEmployee()
{
    Console.Write("Nhập ID nhân viên cần xóa: ");
    int id = int.Parse(Console.ReadLine());
    var emp = employees.FirstOrDefault(e => e.Id == id);
    if (emp != null)
    {
        employees.Remove(emp);
        Console.WriteLine($"✅ Đã xóa nhân viên có ID = {id}");
    }
    else
    {
        Console.WriteLine("❌ Không tìm thấy nhân viên.");
    }
}

// Menu điều khiển
void ShowMenu()
{
    Console.OutputEncoding = Encoding.UTF8;
    SeedEmployees();

    int choice;
    do
    {
        Console.WriteLine("\n========== MENU ==========");
        Console.WriteLine("1. Hiển thị danh sách nhân viên");
        Console.WriteLine("2. Sửa thông tin nhân viên");
        Console.WriteLine("3. Xóa nhân viên");
        Console.WriteLine("0. Thoát");
        Console.Write("Chọn: ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                DisplayEmployees();
                break;
            case 2:
                EditEmployee();
                break;
            case 3:
                DeleteEmployee();
                break;
            case 0:
                Console.WriteLine("👉 Thoát chương trình.");
                break;
            default:
                Console.WriteLine("⚠️ Lựa chọn không hợp lệ.");
                break;
        }
    } while (choice != 0);
}

// Gọi menu khi chạy chương trình
ShowMenu();