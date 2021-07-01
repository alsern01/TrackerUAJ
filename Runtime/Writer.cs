using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UAJ.Tracker
{
    public class Writer
    {
        private static string dataPath = null;

        private static System.IO.StreamWriter _writer;

        public static void Init()
        {
            dataPath = Application.persistentDataPath;
        }

        /// <summary>
        /// Method used to parse and write event info into a .json file
        /// </summary>
        /// <param name="e">Event we want to parse and write to a file</param>
        public static void WriteToFile(Event e)
        {
            _writer =
                new System.IO.StreamWriter(dataPath + "/" + e.GetPath(), true);
            _writer.WriteLine(JsonUtility.ToJson(e));
            _writer.Close();
        }
    }
}
