/* int num;

// этот блок отвечает за ввод данных
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

//Вычислние квадрата
int kvadrat = num * num;

// Вывод ответа на экран
if (kvadrat >= 100) 
{
    Console.WriteLine("Квадрат оказался больше 100 = " + kvadrat);
}
else 
{
    Console.WriteLine("Квадрат оказался меньше 100 = " + kvadrat);
}
 */







//____________________________________________________________________
/* 
// Задам переменные
int num1;
int num2;

// этот блок отвечает за ввод данных первого числа
Console.Write("Введите число: ");
num1 = Convert.ToInt32(Console.ReadLine());

// этот блок отвечает за ввод данных Второго числа
Console.Write("Введите число: ");
num2 = Convert.ToInt32(Console.ReadLine());

// вычисляем квадрат первого числа
int square1 = num1*num1;

// Высняем является ли второе число квалратом первого
if (num2 == square1) {
    // Если да...
    Console.WriteLine("Ура первое число является квадратом второго");
}
else{
    // Если нет
    Console.WriteLine("Упс... первое число НЕ является квадратом второго");
} */








//_________________________________________________
/* 
// Задаем переменные
int num;


// этот блок отвечает за ввод данных 
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num == 1){
    Console.WriteLine("понедельник");
}

else if (num == 2){
    Console.WriteLine("Вторник");
}
else if (num == 3){
    Console.WriteLine("Среда");
}
else if (num == 4){
    Console.WriteLine("Четверг");
}
else if (num == 5){
    Console.WriteLine("Пятница");
}
else if (num == 6){
    Console.WriteLine("суббота");
}
else if (num == 7){
    Console.WriteLine("Воскресение");
}
else {
    Console.WriteLine("Введите число не более 7");
}
*/




//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

//____________________________________________________________________________

int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num*(-1);

while (current<=num){
    Console.Write(current + " " );
    current++;

}













