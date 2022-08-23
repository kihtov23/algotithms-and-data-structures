namespace Algorithms
{
    public class Sorting
    {
        // arr = 6 4 7 2
        // [6]<>[4] 7 2 ->
        // 4 [6]<>[7] 2 ->
        // 4 6 [7]<>[2] ->
        // 4 6 2 | 7
        public static void BubbleSort(int[] arr)
        {
            for (int partIndex = arr.Length - 1; partIndex > 0; partIndex--)
            {
                for (int j = 0; j < partIndex; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }

        //  arr = 6 4 7 2
        // loop and store index of max element [6]<>4 7 2 => 2 4 7 | 6
        public static void SelectionSort(int[] arr)
        {
            for (int partIndex = arr.Length - 1; partIndex > 0; partIndex--)
            {
                int maxIndex = 0;
                for (int i = 0; i <= partIndex; i++)
                {
                    if (arr[i] > arr[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
                Swap(arr, maxIndex, partIndex);
            }
        }

        // arr = 6 4 7 2
        // 6 | 4 7 2, temp = 4, shift left array until temp < el
        // 4 6 | 7 2, if 7 > 6, shift partition
        // 4 6 7 | 2, temp = 2, shift 7, shift, 6, shift 4, -> 2 4 6 7
        public static void InsertionSort(int[] arr)
        {
            //min edge case: partIndex=1, arr[partIndex]=4, i->0..0 arr[i] 6
            //middle         partIndex=2, arr[partIndex]=7, i->1..0 arr[i] 6, 4
            //max edge case: partIndex=3, arr[partIndex]=2, i->2..0 arr[i] 7, 6, 4
            for (int partIndex = 1; partIndex < arr.Length; partIndex++)
            {
                int currUnsorted = arr[partIndex];
                int i = 0;
                for (i = partIndex; i > 0 && arr[i - 1] > currUnsorted; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[i] = currUnsorted;
            }
        }

        public static void MergeSort(int[] arr)
        {
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[b];
            arr[b] = arr[a];
            arr[a] = temp;
        }
    }
}