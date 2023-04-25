
Console.Clear();
if (DateTime.Now.Hour < 12)
{
    Console.WriteLine("Доброк утро");
}
else
{
    Console.WriteLine("Добрый вечер");
}
Console.WriteLine("Введите, пожалуйста, ваше имя и нажмите Enter");
string name=Console.ReadLine();
Console.WriteLine("Введите, пожалуйста, название блюда и нажмите Enter");
string order =Console.ReadLine();
Console.WriteLine("Спасибо за Ваш заказ, {0}! Вы выбрали {1}", name, order);
int time = new Random().Next(5,20);
Console.WriteLine("Ваш заказ будет котов через {0} минут", time);
