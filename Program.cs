using System;

public class CSList
{
    public static void Main()
    {
        // 1次元配列のスライス
        int[] arr1d = new int[] { 0, 1, 2, 3, 4 };
        int start = 1, end = 4;
        var slice1d = arr1d[start..end];

        Console.WriteLine(String.Join(", ", slice1d));


        // 2次元配列のスライス
        int[,] arr2d = new int[4, 4] {
            { 0, 1, 2, 3 },
            { 4, 5, 6, 7 },
            { 8, 9, 10, 11},
            { 12, 11, 13, 14 } };

        // [行方向]
        int row = 1;
        start = 1;
        end = 3;

        var slice2d_row = new int[end - start];
        for (int i = 0; i < (end - start); i++)
        {
            slice2d_row[i] = arr2d[row, (start - i)];
        }

        Console.WriteLine(String.Join(", ", slice2d_row));


        // [列方向]
        int col = 2;
        start = 1;
        end = 3;

        var slice2d_col = new int[end - start];
        for (int i = 0; i < (end - start); i++)
        {
            slice2d_col[i] = arr2d[(start + i), col];
        }

        Console.WriteLine(String.Join(", ", slice2d_col));
    }
}