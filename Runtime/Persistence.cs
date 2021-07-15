using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Persistence
{


    public Persistence()
    {

    }
    public abstract void Send(Event item, string format);

    public abstract void Flush();
}