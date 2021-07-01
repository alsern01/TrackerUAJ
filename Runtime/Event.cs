using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UAJ.Tracker
{
    /// <summary>
    /// Base class for all the tracker events. Contains shared attributes
    /// and functionality
    /// </summary>
    class Event
    {
        public float timeStamp;

        public int playerID;

        protected string path;

        public Event()
        {
        }

        public Event(int playerID)
        {
            Init (playerID);
        }

        public virtual void Init(int playerID)
        {
            this.playerID = playerID;
        }

        public virtual void UpdateInfo(float timeStamp)
        {
            this.timeStamp = timeStamp;
        }

        public string GetPath()
        {
            return path;
        }
    }
}
