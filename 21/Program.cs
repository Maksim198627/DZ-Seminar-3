int q = 3; 
List<double[]> spaceAll;
double result;

spaceAll = EnterСoord(q);

double[] arcs = new double[q]; 
for (int i = 0; i <= q - 1; i++)
{
    double xa = spaceAll[0][i];
    double xb = spaceAll[1][i];

    arcs[i] = Math.Pow(xb - xa, 2); 
}

double sum = 0; 
for (int i = 0; i <= q - 1; i++)
{
    sum += arcs[i];
}

result = Math.Sqrt(sum);
result = Math.Round(result, 2);

Console.WriteLine("Расстояние между точками: " + result);


List<double[]> EnterСoord(int allSpace)
{

    List<double[]> result = new List<double[]>();
    string str = "";

    for (int i = 0; i <= 1; i++) 
    {
    Input:

        
        Console.Write("Введите " + ((allSpace > 1) ? "(через запятую) " : "") + allSpace + "  точки " + ((i == 0) ? "A" : "B") + ": ");

        str = Console.ReadLine()!.Trim(); 
     
        string[] str_ = str.Split(','); 
        
               double[] tempArray = new double[allSpace];

        for (int j = 0; j < str_.Length; j++) 
        {
            
            if (double.TryParse(str_[j], out double a) == true) // если координата  Double
            {
                tempArray[j] = double.Parse(str_[j]); 
            }
            else 
            {
                
                Console.WriteLine("Неверный тип!");

                goto Input;
            }
        }
        result.Add(tempArray);
    }
    return result;
}








