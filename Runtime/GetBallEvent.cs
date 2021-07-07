using UnityEngine;

/// <summary>
/// Class that provides when the player gets the ball
/// </summary>
public class GetBallEvent : Event
{
    public GetBallEvent(int playerID, float timeStamp)
    {
        Init(playerID, timeStamp);
        this.path = "GetBall.json";
    }
}

