using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tracker
{
    private static Queue<Event> pendingEvents = new Queue<Event>();
    private static float _time;

    public static void Init()
    {
        Debug.Log("TRACKER INIT");
        Writer.Init();
    }

    public static void Update()
    {
        while (pendingEvents.Count > 0)
        {
            Writer.WriteToFile(pendingEvents.Dequeue());
        }
    }

    public static void EventExample()
    {
        DefaultEvent e = new DefaultEvent(0, Time.time);
        // Add the event to the pending queue
        pendingEvents.Enqueue(e);
    }
}

