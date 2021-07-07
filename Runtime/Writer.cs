using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Writer
{
    private static string dataPath = null;

    private static System.IO.StreamWriter _writer;

    /// <summary>
    /// Assigns the data path where we want to store the tracker files
    /// </summary>
    public static void Init()
    {
        dataPath = Application.persistentDataPath;
    }

    /// <summary>
    /// Writes the event in the dessigned file
    /// </summary>
    public static void WriteToFile(Event e)
    {
        _writer =
            new System.IO.StreamWriter(dataPath + "/" + e.GetPath(), true);
        _writer.WriteLine(JsonUtility.ToJson(e));
        _writer.Close();
    }
}

