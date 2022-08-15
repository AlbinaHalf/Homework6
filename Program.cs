// Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter). 
// Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write($"Enter the number of numbers М: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = Console.ReadLine().Split().Select(m => Convert.ToInt32(m)).ToArray();

void InputNumbers(int m){
}
int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
InputNumbers(m);
Console.WriteLine($"Entered numbers greater than 0: {Comparison(massiveNumbers)} ");