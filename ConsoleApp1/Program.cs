// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, APBD ????");

Console.WriteLine(GetAvg([1,2,3,4,5]));

//pull, fetch, push, add, 

static double GetAvg(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }

    return result / arr.Length;
}

Console.WriteLine(GetMax([1,2,3,4,5,6,7,10,50]));

static int GetMax(int[] arr)
{
    int max = arr[0];
    foreach (int num in arr)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}