namespace Algorithms
{
    public class Sorting
    {
        // arr = 6 4 7 2
        // [6]<>[4] 7 2 ->
        // 4 [6]<>[7] 2 ->
        // 4 6 [7]<>[2] ->
        // 4 6 2 | 7
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = arr.Length-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}