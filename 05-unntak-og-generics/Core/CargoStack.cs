namespace SpaceAcademy;

public class CargoStack<T>
{
    private List<T> _items = new List<T>();
    public int Count { get { return _items.Count; } }

    public void Push(T item)
    {
        _items.Add(item);
    }

    public T Pop()
    {
        if(_items.Count <= 0)
            throw new InvalidOperationException("Stack is empty");

        int lastIndex = _items.Count - 1;
        T item = _items[lastIndex];
        _items.RemoveAt(lastIndex);
        return item;
    }
}
