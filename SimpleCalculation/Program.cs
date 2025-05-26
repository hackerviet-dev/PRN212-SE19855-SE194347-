void do_calculation(double a, double b , string op)
{
    switch(op)
    {
        case "+":
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            break;
        case "-":
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            break;
        case "/":
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            break;
        default:
                Console.WriteLine("Phép toán không hợp lệ");
            break;
    }    
}
Console.OutputEncoding=System.Text.Encoding.UTF8;
Console.WriteLine("Simple calculation program");
Console.WriteLine("Nhap so a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhap so b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Nhap phep toan (+, -, *, /): ");
string op = Console.ReadLine();
do_calculation(a, b, op);
Console.ReadLine(); 