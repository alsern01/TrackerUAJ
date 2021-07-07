using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootBallEvent : Event
{
    public ShootBallEvent(int playerID, float timeStamp)
    {
        Init(playerID, timeStamp);
        this.path = "ShootBall.json";
    }
}
