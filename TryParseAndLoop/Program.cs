/* Nhap vao so >= 0 , neu nhap sai quy tac yeu cau nhap dung
 * neu nhap dung thi tinh giai thua cua so nay
*/
using System.Text;

int n = -1;//gia su nhap sai
while (n<0)// bat nhap lai khi nao n >= 0
{
    Console.WriteLine("Nhap n >= 0");
    string input = Console.ReadLine();
    if (int.TryParse(input, out n) == true)
    {// khi vao day n la so, nhung co the <= 0
        if (n >= 0)
            break; // khong bat nhap nua
        else
            Console.WriteLine("Da noi la nhap >= 0 ????????");
    }
    else
    {
        Console.WriteLine("Da noi nhap so ?????");
    }
}
int gt = 1;
for (int i = 1; i <= n; i++)

    gt *= i;
Console.WriteLine($"{n} != {gt}");
Console.OutputEncoding = Encoding.UTF8;