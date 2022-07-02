using System;

namespace home2Csh
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
             на выходе показывает вторую цифру этого числа.
            456 -> 5; 782 -> 8; 918 -> 1
            Задача 13: Напишите программу, которая выводит третью цифру заданного 
            числа или сообщает, что третьей цифры нет.
            645 -> 5
            78 -> третьей цифры нет
            32679 -> 6
            Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            6 -> да
            7 -> да
            1 -> нет*/
			int number = 1;
			int num;

			while (number != 0)
			{
				Console.Clear();
				Console.WriteLine("введите номер задачи или введите 0 для выхода\n" +
					"1. введите 3х значное число, на выходе программа выдает второе число\n" +
					"2. введите число, на выходе 3я цифра или нет цифры\n" +
					"3. введите номер дня недели, на выходе рабочий или выходной день\n" +
					"0. выход\n");
				number = Convert.ToInt32(Console.ReadLine());
				if (number == 1)
				{   //принимает на вход трехзначное число, на выходе вторая цифра. 456=5
					//while()
					Console.WriteLine("введите трехзначное число, на выходе 2е число\n");
					num = Convert.ToInt32(Console.ReadLine());
					if ((num > -999 & num < -99) | (num < 999 & num > 99))
					{
						num = (num / 10)%10; 
						Console.WriteLine(num );

					}
					else Console.WriteLine("число не трехзначное!\n");
					Console.WriteLine("нажмите любую клавишу");
					Console.ReadKey();
				}
				else if (number == 2)
				{   /*выводит третью цифру заданного числа или сообщает что такой нет
					4578=7
					56=нет
					564=4*/
					Console.WriteLine("введите число\n на выходе 3-е число, или нет цыфры \n");
					num = Convert.ToInt32(Console.ReadLine()); //ограничивает только вместимость inta
					if (num < 99 & num > -99)
						Console.WriteLine("нет третьей цифры\n");
					else
					{
						if (num > 999 | num < -999)
						{
							for (; num > 1000 | num < -1000;)
								num /= 10;
						}
						Console.WriteLine(num % 10);
					}
					Console.WriteLine('\n');
					Console.WriteLine("нажмите любую кнопку");
					Console.ReadKey();
				}
				else if (number == 3)
				{   /*принимает цифру, обозначающую день недели и проверяет, 
					является ли этот день выходным.
					6->выходной
					7- выходной
					4 - нет*/
					Console.WriteLine("введите номер дня недели\n");
					num = Convert.ToInt32(Console.ReadLine());
					switch (num)
					{
						case 1:
							Console.WriteLine("это рабочий день. понедельник\n");
							break;
						case 2:
							Console.WriteLine("это рабочий день. вторник\n");
							break;
						case 3:
							Console.WriteLine("это рабочий день. среда\n");
							break;
						case 4:
							Console.WriteLine("это рабочий день. четверг\n");
							break;
						case 5:
							Console.WriteLine("это рабочий день. пятница. завтра выходной\n");
							break;
						case 6:
							Console.WriteLine("это выходной. суббота\n");
							break;
						case 7:
							Console.WriteLine("это выходной. воскресенье. завтра на работу\n");
							break;
						default:
							Console.WriteLine("в неделе только 7 дней!\n");
							break;
					}
					Console.WriteLine("нажмите любую клавишу");
					Console.ReadKey();
					
				}
			}
		}
	}
}

