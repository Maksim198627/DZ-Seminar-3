int n = CheckNumber();

bool palindromnumber = true;

Console.WriteLine("Результат: " + ((palindromnumber == true) ? "" : "не ") + "палиндром.");



int CheckNumber()
{
    int result = 0; 
    string str = ""; 
    bool check = false; 

    do
    {
        Console.Write("Введите число: ");

        str = Console.ReadLine()!.Trim();

        if (int.TryParse(str, out result) == false) 
        {

            Console.WriteLine("Введено не число!");
            continue;
        }

        result = int.Parse(str); 

        if (result < 1) 
        {

            Console.WriteLine("Ненатуральное число!");
            continue;
        }
        if (result < 10000 || result > 99999) 
        {
            Console.WriteLine("Не пятизначное число!");
            continue;
        }

        check = true; 
    } while (check == false);
    return result;
}

