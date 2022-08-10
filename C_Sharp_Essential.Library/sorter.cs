namespace C_Sharp_Essential.Library;

public class sorter<T> where T : class, IComparable<T>, new()
    {
    public void sort(T[] items)
        {
        for(int i = 1; i < items.Length; i++)
            {
            if(items[i].CompareTo(items[i - 1]) < 0)
                {
                swap(items, i, i - 1);
                }
            }
        }

    public void swap(T[] items, int index1, int index2)
        {
        T temp = items[index2];
        items[index2] = items[index1];
        items[index1] = temp;
        }
    }
