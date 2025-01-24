Counter counter = new Counter();

Thread incrementThread = new Thread(() =>
{
    for (int i = 0; i < 10; i++) counter.Increment();
});

Thread decrementThread = new Thread(() =>
{
    for (int i = 0; i < 10; i++) counter.Decrement();
});

incrementThread.Start();
decrementThread.Start();
incrementThread.Join();
decrementThread.Join();

class Counter
{
    private int _count;
    private readonly object _lock = new object();

    public void Increment()
    {
        lock (_lock)
        {
            _count++;
            Console.WriteLine($": {_count}");
        }
    }

    public void Decrement()
    {
        lock (_lock)
        {
            _count--;
            Console.WriteLine($"Декремент: {_count}");
        }
    }

    public int GetValue()
    {
        lock (_lock)
        {
            return _count;
        }
    }
}
//правильно ли я понял задание?



