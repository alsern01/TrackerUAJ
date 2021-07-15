/// <summary>
/// Class that provides when the player lost the ball and the way he lost it
/// </summary>
class LoseBallEvent : Event
{
    public bool playerDead;

    public LoseBallEvent(int playerID, float timeStamp, bool dead)
    {
        Init(playerID, timeStamp);
        this.playerDead = dead;
        this.path = "LoseBall.json";
    }
}
