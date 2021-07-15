/// <summary>
/// Base class for all the tracker events. Contains shared attributes
/// and functionality
/// </summary>
public class Event
{

    public enum eventType{ SHOT , PICKBALL, LOSEBALL, CAMERAANGLE, MOVECAMERA};

    public float timeStamp;

    public int playerID;

    protected string path;

    public Event()
    {
    }

    public Event(int playerID)
    {
        this.playerID = playerID;
    }

    public void Init(int playerID, float timeStamp)
    {
        this.playerID = playerID;
        this.timeStamp = timeStamp;
    }

    public string GetPath()
    {
        return path;
    }
}
