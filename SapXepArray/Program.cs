void swap(ref int a, ref int b)
{
    int temp = a;
    a=b;
    b=temp;
}
void sort_arr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = i + 1;  j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                               swap(ref arr[i], ref arr[j]);
            }
        }

    }
}
void sort_arr_use_while(int[] arr)
{
    int i = 0; int j = i + 1;
    while(i < arr.Length)
    {
        while(j < arr.Length)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        i++;
        j = i + 1;
    }
}
void sort_arr_use_do_while(int[] arr)
{
    int i = 0; int j = i + 1;
    do
    {
        do
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        } while (j < arr.Length);
        i++;
        j = i + 1;
    } while (i < arr.Length - 1);
}
void create_array(int[] arr)
{
    Random rd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(1, 100);
    }
}
void print_array(int[] arr)
{
   foreach (int x in arr)
   {
       Console.Write($"{x}\t");
    }
}
int []arr= new int[10]; 
create_array(arr);
Console.WriteLine("Mang truoc khi sap xep: ");
print_array(arr);
Console.WriteLine("Mang sau khi sap xep");
sort_arr(arr);
print_array(arr);
