
public readonly struct LevelInfo
{
    public LevelInfo(string levelName, int completion, Proportion oranges, Proportion reds)
    {
        LevelName = levelName;
        Completion = completion;
        Oranges = oranges;
        Reds = reds;
    }

    public string LevelName { get; }
    public int Completion { get; }
    public Proportion Oranges { get; }
    public Proportion Reds { get; }
}
