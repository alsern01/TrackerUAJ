using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Persistence
{
   
 
    public Persistence()
    {
       
    }
    public abstract void Send(Event item, string format);

    public void Flush();
}