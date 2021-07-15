using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public static class Tracker
{

    //https://answers.unity.com/questions/891380/unity-c-singleton.html

    #region TRACKER INSTANCE
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
    #endregion


    // Queue for the event management
    private static Queue<Event> pendingEvents = new Queue<Event>();
    // Manages the thread loop
    private static bool exit_ = false;
    //Persistence object
    Persistence persisteneObj;

    /// <summary>
    /// Call this to initialise the Tracker thread and the Writer class
    /// </summary>
    public static void Init()
    {
        persisteneObj = new Persistence();
        Debug.Log("TRACKER INIT");

        Thread t = new Thread(new ThreadStart(EventUpdate));
        t.Start();
    }

    /// <summary>
    /// Call this to end the thread update loop
    /// </summary>
    public static void Exit()
    {
        Debug.Log("TRACKER END");
        exit_ = true;
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
                persisteneObj.Send(pendingEvents.Dequeue(),"json");
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
}

