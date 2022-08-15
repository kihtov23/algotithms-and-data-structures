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
            for (int partIndex = arr.Length-1; partIndex > 0; partIndex--)
            {
                for (int j = 0; j < partIndex; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
            return arr;
        }

        //  arr = 6 4 7 2
        // store index if max [6]<>4 7 2 => 2 4 7 | 6
        public static int[] SelectionSort(int[] arr)
        {
            int maxIndex = 0; 
            for (int partIndex = arr.Length-1; partIndex > 0; partIndex--)
            {
                maxIndex = 0;
                for (int i = 0; i <= partIndex; i++)
                {
                    if (arr[i] > arr[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
                Swap(arr, maxIndex, partIndex);
            }
            return arr;
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[b];
            arr[b] = arr[a];
            arr[a] = temp;
        }
    }
}