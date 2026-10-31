using System;
using System.Collections;
using System.Linq.Expressions;

Console.WriteLine("===- Казино -===");
Console.WriteLine("1.Слоты");
Console.WriteLine("2.Кости");
Console.WriteLine("3.Счёт");

int just_coin = 1000;

string user_enter_menu = Convert.ToString(Console.ReadLine());

switch (user_enter_menu)
{
    case "1":
        Random rnd = new Random();                        
string[] slots = { "Яблоко", "Вишня", "Колакал", "7" };
int coin = 1000;                                   
const int STAKE = 100;                             

while (true)
{
    if (coin < STAKE)
    {
        Console.WriteLine("Денег не хватает на ставку. Игра окончена.");
        break;
    }

    coin -= STAKE;                                 

    string s1 = slots[rnd.Next(slots.Length)];
    string s2 = slots[rnd.Next(slots.Length)];
    string s3 = slots[rnd.Next(slots.Length)];

    Console.WriteLine($"\n{s1} | {s2} | {s3}");

    if (s1 == s2 && s2 == s3)
    {
        
        coin += STAKE + 1000;
        Console.WriteLine("+ 100 монет (три в ряд!)");
    }
    else
    {
        Console.WriteLine($"- {STAKE} монет");
    }

    Console.WriteLine($"Ваш баланс: {coin}");

    Console.Write("Введи 'Крутить' чтобы играть ещё, или 'Выход' если хотите вернутся в меню: ");
    string user_enter = Console.ReadLine();

            if (user_enter == "Выход")
            {
                break;
            }
}
            
        
        break;                  
    case "2":
        Console.WriteLine("---Кости---");
        int jjust_coin = 1000;

        while (true)
        {

            if (jjust_coin >= 100)
            {
                int Breakfirst = Random.Shared.Next(1, 7);

                if (Breakfirst <= 1)
                {
                    jjust_coin = jjust_coin - 100;
                    Console.WriteLine($"Вам выпало {Breakfirst} , -100 .Ваш счет: {jjust_coin}");
                    Console.WriteLine("Если хотите продолжить напишите -продолжить-, если вы хотите выйти напищите -выход-");
                    string user_enter = Convert.ToString(Console.ReadLine());
                    if(user_enter == "выход")
                    {
                        break;
                    }

                    break;
                }
                else if (Breakfirst <= 2 || Breakfirst == 3)
                {
                    jjust_coin = jjust_coin - 50;
                    Console.WriteLine($"Вам выпало {Breakfirst} , -50 .Ваш счет: {jjust_coin}");
                    Console.WriteLine("Если хотите продолжить напишите -продолжить-, если вы хотите выйти напищите -выход-");
                    string user_enter = Convert.ToString(Console.ReadLine());
                    if (user_enter == "выход")
                    {
                        break;
                    }
                }
                else if (Breakfirst <= 4 || Breakfirst >= 6)
                {
                    jjust_coin = jjust_coin + 100;
                    Console.WriteLine($"Вам выпало {Breakfirst} , +100 .Ваш счет: {jjust_coin}");
                    Console.WriteLine("Если хотите продолжить напишите -продолжить-, если вы хотите выйти напищите -выход-");
                    string user_enter = Convert.ToString(Console.ReadLine());
                    if (user_enter == "выход")
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Не хватает денег (");
            }
        }

        break;
    case "3":
        Console.WriteLine($"Ваш счёт: {just_coin}");
        Console.WriteLine("Если хотите выйти напишите 'Выход'");
        string user_enter_3 = Convert.ToString(Console.ReadLine());
        if(user_enter_3 == "Выход")
        {
            break;
        }
        break;
    default:
        Console.WriteLine("Нет такого пункта");
        break;
}