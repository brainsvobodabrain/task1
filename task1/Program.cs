//ЗАДАНИЕ 1
Console.WriteLine("Hello, World!");
int a;
int b;
System.Console.Write("Введите число a: ");
a=Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число b: ");
b=Convert.ToInt32(System.Console.ReadLine());
if (a>b){
    System.Console.WriteLine("a = "+a.ToString()+", b = "+b.ToString()+", max = "+a.ToString());
}else{
    System.Console.WriteLine("a = "+a.ToString()+", b = "+b.ToString()+", max = "+b.ToString());
}