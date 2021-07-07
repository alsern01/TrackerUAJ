using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Tracker
{
    private static Queue<Event> pendingEvents = new Queue<Event>();
    private static float _time;

    public static void Init()
    {
        Writer.Init();
    }

    public static void Update()
    {
        foreach (Event e in pendingEvents)
        {
            Writer.WriteToFile(e);
            Debug.Log("ASHAKJSHAJSHAJSH");
        }
    }

    public static void EventExample()
    {
        Event e = new Event();
        e.Init(0, Time.time);

        // Add the event to the pending queue
        pendingEvents.Enqueue(e);
    }
}

