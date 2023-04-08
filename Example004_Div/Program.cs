Console.WriteLine("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
int Quad = Num2 * Num2;
if (Quad == Num1){
    Console.WriteLine($"число {Num1} является квадратом {Num2}");
}
else{
        Console.WriteLine($"число {Num1} не является квадратом {Num2}");

}
