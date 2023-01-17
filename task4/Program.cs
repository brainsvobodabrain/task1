// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int n;
System.Console.Write("Введите число n: ");
n=Convert.ToInt32(System.Console.ReadLine());
for (int i=1;i<=n;i++){
    if (i%2==0){
        System.Console.Write(i.ToString()+" ");
    }
}