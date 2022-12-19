// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int rec(int n, int m); 

{
   if (m == 0) 
   return (n * (n + 1)) / 2;            
   else if (n == 0)
    return (m * (m + 1)) / 2;       
    else if (m == n) 
    return M;                       
    else if (m < n) 
    return n + rec(m, n - 1); 
    else 
    return n + rec(m, n + 1);    
}
Console.Clear();
Console.Write("Введите 1-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
Console.Write("Введите 1-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}



