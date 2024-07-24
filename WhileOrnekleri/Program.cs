//writes "Kendime inanıyorum, ben bu yazılım işini hallederim!" 10 times:
int i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

//writes numbers from 1 to 20 with comma in between:
Console.WriteLine("");
Console.WriteLine("1 ile 20 arasındaki sayılar:");
int y = 1;
while (y < 21)
{
    if (y == 20)
    {
        Console.Write($"{y}");
    }
    else
    {
        Console.Write($"{y}, ");
    }
    y++;
}

//writes even numbers between 1 and 20 with comma in between:
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("1 ile 20 arasındaki çift sayılar:");
int z = 1;
while (z < 21)
{
    if (z % 2 == 0)
    {
        if (z == 20)
        {
            Console.Write($"{z}");
        }
        else
        {
            Console.Write($"{z}, ");
        }
    }
    z++;
}


//defined a variable num = 0, and added every number from 50 to 150:
int k = 50;
int sum = 0;
while (k < 151)
{
    sum = sum + k;
    k++;
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {sum}'dır.");

//defined to variables to hold odd and even numbers seperately and added the appropriate numbers from 1 to 120 to each of them:
int oddNums = 0;
int evenNums = 0;
int l = 1;
while (l < 121)
{
    if ((l % 2) == 0)
    {
        evenNums = evenNums + l;
    }
    else
    {
        oddNums = oddNums + l;
    }
    l++;
}
Console.WriteLine("");
Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenNums}'dır.");
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {oddNums}'dır.");