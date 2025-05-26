using System.Text;

void first_degree_solutions(double a , double b)
    {
        if(a == 0 && b == 0)
                
            //0x=0
            Console.WriteLine( "Phương trình có vô số nghiệm");
        
        else if(a == 0 && b != 0)
        
            //0x=b (b!=0) => vô nghiệm
            Console.WriteLine("Phương trình vô nghiệm");
        
        else
        
            //ax+b=0 => x=-b/a => có nghiệm duy nhất  
            Console.WriteLine("X={0}", -b/a);
    
}
void quadratic_equation_solutions(double a , double b , double c)
{
   if(a == 0)
   first_degree_solutions(b, c);
    else
    {
        var delta = Math.Pow(b , 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}", -b / (2 * a));
        }
        else
        {
          var x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phương trình có 2 nghiệm phân biệt x1 = {0} \n x2 = {1}", x1, x2);

        }
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phương trình bậc 2: ax^2+bx+c=0");
Console.WriteLine("Hệ số a: ");
var a = double.Parse(Console.ReadLine());
Console.WriteLine("Hệ số b: ");
var b = double.Parse(Console.ReadLine());
Console.WriteLine("Hệ số c: ");
var c = double.Parse(Console.ReadLine());
quadratic_equation_solutions(a, b, c);
Console.ReadLine();