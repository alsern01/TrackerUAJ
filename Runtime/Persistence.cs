using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Persistence
{
   
    Writer w;
    public Persistence()
    {
        w.Init();
    }
    public void Send(Event item,string format)
    {
        w.WriteToFile(item,format);
    }

    public void Flush() { }
}