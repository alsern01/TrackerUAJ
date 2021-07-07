using UnityEngine;

/// <summary>
/// Base class for all the tracker events. Contains shared attributes
/// and functionality
/// </summary>
class Event
{
    public float timeStamp;

    public int playerID;

    protected string path;

    public Event()
    {
    }

    public Event(int playerID)
    {
        this.playerID;
    }

    public void Init(int playerID, float timeStamp)
    {
        this.playerID;
        this.timeStamp = timeStamp;
    }

    public string GetPath()
    {
        return path;
    }
}
