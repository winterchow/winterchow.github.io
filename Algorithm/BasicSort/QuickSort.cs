// Solution 1
public int[] SimpleQuickSort(int[] array)
{
    if(array.Length < 2)
    {
        return array;
    }
    else
    {
        int mid = array[0];
        // It will resize every time, better to initialize with count. 
        List<int> small = new List<int>();
        List<int> big = new List<int>();

        for(int i = 1; i < array.Length; i++)
        {
            if(array[i] > array[0])
            {
                big.Add(array[i]);
            }
            else
            {
                small.Add(array[i]);
            }
        }
        small.Add(array[0]);
        int[] smallArray = small.ToArray();
        int[] bigArray = big.ToArray();

        return SimpleQuickSort(smallArray).Concat(SimpleQuickSort(bigArray)).ToArray();
    }
}

// Solution 2
public void QuickSort(int[] array, int low, int high)
{
    if(low < high)
    {
        int key = Partition(array, low, high);

        QuickSort(array, low, key - 1);
        QuickSort(array, key + 1, high);
    }
}

private int Partition(int[] array, int low, int high)
{
    int pivot = array[high];
    int i = low - 1;
    for(int j = low; j < high; j++){
        if(array[j] < pivot){
            i++;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    int foo = array[i + 1];
    array[i + 1] = array[high];
    array[high] = foo;

    return i + 1;
}