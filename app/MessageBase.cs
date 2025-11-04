public abstract classe messageBase
{
    public MassageBase(string massage)
    {
        Massage = massage;
        SendAt = DataTime.Now;
    }

    public string Massage { get; }
    public DataTime SendAt { get; }
}