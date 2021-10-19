public class Proportion 
{
    public Proportion(int size)
    {
        Size = size;
        Current = 0;
    }
    
    public int Size
    {
        get;
    }

    public int Current
    {
        get;
        private set;
    }
    
    public bool IsFull
    {
        get => Size == Current;
    }

    public bool IsEmpty
    {
        get => Size == 0;
    }

    public void AddOne()
    {
        Current++;
    }

    public override string ToString()
    {
        return $"{Current}/{Size}";
    }
}
