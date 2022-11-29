try
{
    int m = 4, n = 4;
    int[,] arr = new int[m, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= arr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > arr.GetLength(1) - 1)
            j--;
        else
            i--;
    }

    for(int r = 0; r < m; r++)
    {
        for (int k = 0; k < n; k++)
        {
            Console.Write((arr[r, k] < 10) ?"0{0} " : "{0} ", arr[r, k]);
        }
        Console.WriteLine();
    }

}
catch(Exception err)
{
    Console.WriteLine(err);
}