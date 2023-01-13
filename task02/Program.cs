// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру. 3 -> Среда 5 -> Пятница

Console.Write("Введите номер дня недели: ");
string number_day = Console.ReadLine();
 if (number_day == "1")
 {
    Console.WriteLine("Понедельник");
 }
 else if (number_day == "2")
 {
    Console.WriteLine("Вторник");
 }
  else if (number_day == "3")
 {
    Console.WriteLine("Среда");
 }
  else if (number_day == "4")
 {
    Console.WriteLine("Четверг");
 }
  else if (number_day == "5")
 {
    Console.WriteLine("Пятница");
 }
  else if (number_day == "6")
 {
    Console.WriteLine("Суббота");
 }
  else if (number_day == "7")
 {
    Console.WriteLine("Воскресенье");
 }
 else
 {
    Console.WriteLine("Неправильный ввод. Введите число от 1 до 7");
 }
