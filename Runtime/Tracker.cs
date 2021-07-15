using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public static class Tracker
{

    //https://answers.unity.com/questions/891380/unity-c-singleton.html

    /*#region TRACKER INSTANCE
    public static Tracker _instance;
    public static Tracker Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Tracker();
            }

            return _instance;
        }
    }
    #endregion*/
    // Queue for the event management
    private static Queue<Event> pendingEvents = new Queue<Event>();
    // Manages the thread loop
    private static bool exit_ = false;
    //Persistence object
    static FilePersistence persisteneObj;

    public static float timeStamp;

    private static int playerID;

    private static float camAngle;

    private static bool dead;

    public static void setPlayerId(int pID)
    {
        playerID = pID;
    }

    public static void setTimeStamp(float tiemS)
    {
        timeStamp = tiemS;
    }

    public static void setCameraAngle(float a)
    {
        camAngle = a;
    }

    public static void setDead(bool d)
    {
        dead = d;
    }


    /// <summary>
    /// Call this to initialise the Tracker thread and the Writer class
    /// </summary>
    public static void Init()
    {
        persisteneObj = new FilePersistence();

        Thread t = new Thread(new ThreadStart(EventUpdate));
        t.Start();

        Debug.Log("TRACKER INIT");
    }

    /// <summary>
    /// Call this to end the thread update loop
    /// </summary>
    public static void Exit()
    {
        exit_ = true;
        Debug.Log("TRACKER END");
    }

    /// <summary>
    /// Thread update
    /// Writes all the events pending to write
    /// </summary>
    public static void EventUpdate()
    {
        while (!exit_)
        {
            while (pendingEvents.Count > 0)
            {
                persisteneObj.Send(pendingEvents.Dequeue(), "json");
            }
            Thread.Sleep(500);
        }
    }

    /// <summary>
    /// Just a test event
    /// </summary>
    public static void EventExample()
    {
        DefaultEvent e = new DefaultEvent(0, Time.time);
        // Add the event to the pending queue
        pendingEvents.Enqueue(e);
    }

    public static void CreateEvent(Event.eventType etype)
    {
        switch (etype)
        {
            case Event.eventType.SHOT:

                ShootBallEvent shotWBall = new ShootBallEvent(playerID, timeStamp);
                pendingEvents.Enqueue(shotWBall);
                break;

            case Event.eventType.PICKBALL:

                GetBallEvent getBallEv = new GetBallEvent(playerID, timeStamp);
                pendingEvents.Enqueue(getBallEv);
                break;

            case Event.eventType.LOSEBALL:

                LoseBallEvent loseBall = new LoseBallEvent(playerID, timeStamp, dead);
                pendingEvents.Enqueue(loseBall);
                break;

            case Event.eventType.CAMERAANGLE:

                ExtremeAngleEvent cameraAng = new ExtremeAngleEvent(playerID, timeStamp, camAngle);
                pendingEvents.Enqueue(cameraAng);
                break;

            case Event.eventType.MOVECAMERA:

                CameraMovementEvent movementCamera = new CameraMovementEvent(playerID, timeStamp);
                pendingEvents.Enqueue(movementCamera);

                break;
        }
    }
}

