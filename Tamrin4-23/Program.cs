Console.WriteLine("Enter an Integer");

int n = Convert.ToInt32(Console.ReadLine());
int[,] vs1 = new int[n, n];
int[,] vs2 = new int[n, n];
int[,] result = new int[n, n];
Console.WriteLine("Enter First Matrix");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        vs1[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Enter Second Matrix");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        vs2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        result[i, j] = vs1[i, j] + vs2[i, j];
    }
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine(" ");
    for (int j = 0; j < n; j++)
    {
        Console.Write(result[i, j]);
    }
}

//---------------------Part2------------------

//plusOut("12xy34xyabcxy", "xy");

void plusOut(string aString1, string aString2)
{
    int x = 0;
    char[] result = new Char[aString1.Length];
    for(int i = 0; i < aString1.Length; i++)
    {
        for(int j = 0; j < aString2.Length; j++)
        {
            if(aString1[i] == aString2[j])
            {
                x++;
            }
        }
    }
    if(x != 0 && x % aString2.Length == 0)
    {
        for(int i = 0; i < aString1.Length; i++)
        {
            for(int k = 0; k < aString2.Length; k++)
            {
                if(aString1[i] != aString2[k])
                {
                    result[i] = '+';
                }
                else
                {
                    result[i] = aString2[k];
                    break;
                }
            }
        }
    }
    foreach(char c in result)
    {
        Console.Write(c);
    }
}

//---------------------Part3---------------------

OneTwo("abc");

void OneTwo(string aString)
{
    int n = aString.Length / 3;
    char[] result = new char[aString.Length];
    int k = 0;
    if(aString.Length % 3 == 0)
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < n; j++)
            {
                result[k + 2] = aString[k];
                k += 3;
                result[i] = aString[i + 1];
            }
        }
    }
    foreach(char c in result)
    {
        Console.WriteLine(c);
    }
}