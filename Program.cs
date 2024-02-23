// // //See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

//----------------------------------------------------------

// Console.WriteLine("Введите первое число: ");
//  int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
//  int b = Convert.ToInt32(Console.ReadLine());

//  if (a > b)
// {
//    Console.WriteLine("Первое число больше");
// }

// else if (a < b)

// {
//   Console.WriteLine("Второе число больше");
// }

// else Console.WriteLine("Числа равные");

//----------------------------------------------------------

// Console.WriteLine("Введите первое число: ");
//  int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
//  int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
//  int c = Convert.ToInt32(Console.ReadLine());
//  int max = 0;

// if (a>b)
// {
//  max = a;
// }
// else max = b;

// if (c>max)

// {
//     max = c;    
//     Console.WriteLine("Максимальное число = " + max);
// }
// else Console.WriteLine("Максимальное число = " + max);

Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int i = 1;
      
      while (i <= number)
        
      {
        
        if (i % 2 == 0)

        {

            Console.Write($"{i} ");
            i ++;

        }

        else i ++;
        
        
      }