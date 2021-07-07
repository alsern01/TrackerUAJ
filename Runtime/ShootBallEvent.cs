class ShootBallEvent : Event
{
    public ShootBallEvent(int playerID, float timeStamp)
    {
        Init(playerID, timeStamp);
        this.path = "ShootBall.json";
    }
}
