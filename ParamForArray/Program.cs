int sum(params int[]arr)
{
    int s = 0;
    foreach (int x in arr)
        s += x;
    return s;
}
Console.WriteLine(sum);
Console.WriteLine(sum(1,4,5));
Console.WriteLine(sum(1,5,,6,6,47,665,7));    