// Console.WriteLine("Введите первое число: ");
// int Num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int Num2 = Convert.ToInt32(Console.ReadLine());
// double Quad = Math.Pow(Num2,2);
// if (Quad == Num1){
//     Console.WriteLine($"число {Num1} является квадратом {Num2}");
// }
// else{
//         Console.WriteLine($"число {Num1} не является квадратом {Num2}");

// }

// int N = int.Parse(System.Console.ReadLine());
// for (int i = -N; i <= N; i++)
// {
//     Console.WriteLine(i);
// }

System.Console.WriteLine("Введите целое трехзначное число: ");
int A = 0;
int B = 0;
A = int.Parse(Console.ReadLine());
if(A >= 100 && A <= 1000){
    B = A % 10;
    System.Console.WriteLine("все верно! ");
    System.Console.WriteLine(B);
}
else{
    System.Console.WriteLine("Ошибка! ");

}



