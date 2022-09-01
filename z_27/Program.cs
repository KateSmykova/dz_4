Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNum(int num)
  {  
    int count = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

int sumNum = SumNum(num);
Console.WriteLine("Сумма цифр в числе: " + sumNum);