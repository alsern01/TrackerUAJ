/// <summary>
/// Default event just to test functionality
/// </summary>
class DefaultEvent : Event
{
    public DefaultEvent(int playerID, float timeStamp)
    {
        Init(playerID, timeStamp);
        this.path = "Default.json";
    }
}
