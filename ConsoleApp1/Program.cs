// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, APBD ????");

Console.WriteLine(GetAvg([1,2,3,4,5]));

static double GetAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
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