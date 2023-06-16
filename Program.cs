//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
string inputstring = Console.ReadLine();
int numberN = Convert.ToInt32(inputstring);
List<int> ListNumbers = new List<int>();
for (int num = 1; num <= numberN; num++)
{
if ((num % 2) == 0)
{
ListNumbers.Add(num);    
}  
}
Console.WriteLine(string.Join(", ", ListNumbers));
