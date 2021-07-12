/// <summary>
/// Class that provides information when the player gets a camera extreme angle
/// </summary>
class ExtremeAngleEvent : Event
{
    public float angle;

    public ExtremeAngleEvent(int playerID, float timeStamp, float angle)
    {
        Init(playerID, timeStamp);
        this.angle = angle;
        this.path = "ExtremeAngle.json";
    }
}