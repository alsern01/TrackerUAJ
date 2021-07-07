class DefaultEvent : Event
{
    public DefaultEvent(int playerID, float timeStamp)
    {
        Init(playerID, timeStamp);
        this.path = "Default.json";
    }
}
