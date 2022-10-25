
string result = "";
double n = EntNumber();

for (double i = 1; i <= n; i++)
{
    if (i > 1) result += "; ";
    result += "[" + i + "]=[" + Math.Pow(i, 3) + "]";
}


Console.WriteLine(" Итоговый результат (число = куб числа): " + result);



// Функция ввода и проверки числа N
double EntNumber()
{
    int result = 0;
    string str = "";
    bool check = false;

    do
    {

        Console.Write("Введите число N: ");

        str = Console.ReadLine()!.Trim();

        if (int.TryParse(str, out result) == false)
        {

            Console.WriteLine("Введено не число!");

            continue;
        }


        result = int.Parse(str); 

        if (result < 1) 
        {

            Console.WriteLine("Введите натуральное число!");

            continue;
        }

        check = true;
    } while (check == false);
    return Convert.ToDouble(result);
}





