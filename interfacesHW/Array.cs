

class Array : IOutput, IMath, ISort
{
    
    public int[] data { get; set; }

    public Array(params int[] array)
    {
        data = array;
    }

    public int Max()
    {
        if (data.Length == 0)
        {
            throw new InvalidOperationException();
        }
        return data.Max();
    }

    public int Min()
    {
        if (data.Length == 0)
        {
            throw new InvalidOperationException();
        }
        return data.Min();
    }

    public float Avg()
    {
        if (data.Length == 0)
        {
            throw new InvalidOperationException();
        }
        return (float)data.Sum() / data.Length;
    }

    public bool Search(int valueToSearch)
    {
        return data.Contains(valueToSearch);
    }

    public void Show(string info)
    {
        {
            foreach (int item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(info);
        }
    }

    public void Show()
    {
        Show("");
    }



    public void SortAsc()
    {
        BubbleSort(true);
    }

    public void SortDesc()
    {
        BubbleSort(false);
    }

    public void SortByParam(bool isAsc)
    {
        BubbleSort(isAsc);
    }

    private void BubbleSort(bool ascending)
    {
        int n = data.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((ascending && data[j] > data[j + 1]) || (!ascending && data[j] < data[j + 1]))
                {
                    // Обмен элементов
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    } }
