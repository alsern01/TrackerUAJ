using UnityEngine;

/// <summary>
/// Class that provides information about any camera movement the player makes
/// </summary>
class CameraMovementEvent : Event
{
    public CameraMovementEvent(int playerID, float timeStamp)
    {
        Init(playerID, timeStamp);
        this.path = "CameraMovement.json";
    }
}
