//ЗАДАНИЕ 2
int a;
int b;
int c;
System.Console.Write("Введите число a: ");
a=Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число b: ");
b=Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число c: ");
c=Convert.ToInt32(System.Console.ReadLine());

if (a>b&&a>c){
    System.Console.WriteLine(a.ToString()+","+b.ToString()+","+c.ToString()+" -> max = "+a.ToString());
}else if(b>a&&b>c){
    System.Console.WriteLine(a.ToString()+","+b.ToString()+","+c.ToString()+" -> max = "+b.ToString());
}else if(c>a&&c>b){
    System.Console.WriteLine(a.ToString()+","+b.ToString()+","+c.ToString()+" -> max = "+c.ToString());
}else{
    System.Console.WriteLine(a.ToString()+","+b.ToString()+","+c.ToString()+" -> max = Возможно есть 2 максимума");
}