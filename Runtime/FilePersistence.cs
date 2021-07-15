using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilePersistence : Persistence
{

    //Writer w;
    public FilePersistence()
    {
        Writer.Init();
    }

    public override void Send(Event item, string format)
    {
        Writer.WriteToFile(item, format);
    }

    public override void Flush()
    {

    }

}