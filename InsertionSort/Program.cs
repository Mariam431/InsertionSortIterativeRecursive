namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 10, 2, 7, 7, 28, 100, 3 };
            int n = array.Length;
            Console.WriteLine(InsertionSortIterative(array));

            static int[] InsertionSortIterative(int[] arr)
            {
                int n = arr.Length;
                for (int i = 1; i < n; i++)
                {
                    int key = arr[i];
                    int j = i - 1;
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = key;
                }
                return arr;
            }




            static int[] InsertionSortRecursive(int[] arr, int n)
            {
                if (n <= 1)
                    return arr;

                InsertionSortRecursive(arr, n - 1);
                int last = arr[n - 1];
                int j = n - 2;
                while (j >= 0 && arr[j] > last)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = last;
                return arr;
            }

            Console.WriteLine(InsertionSortRecursive(array, n));












        }
    }
}


