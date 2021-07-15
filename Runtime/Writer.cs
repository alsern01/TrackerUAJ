using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
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
    public static void WriteToFile(Event e,string format)
    {
        switch (format)
        {
            case "json":
                {
                    _writer = new System.IO.StreamWriter(dataPath + "/" + e.GetPath(), true);
                    //Debug.Log(dataPath + "/");
                    _writer.WriteLine(JsonUtility.ToJson(e));
                    _writer.Close();
                    break;
                }
            case "xml":
                {
                    var serializer = new XmlSerializer(typeof(MonsterContainer));
                    var stream = new FileStream(dataPath + "/" + e.GetPath(), FileMode.Create));
                    serializer.Serialize(e, this);
                    stream.Close();
                   /* _writer = new System.IO.StreamWriter(dataPath + "/" + e.GetPath(), true);
                    //Debug.Log(dataPath + "/");
                    _writer.WriteLine(JsonUtility.ToJson(e));
                    _writer.Close();*/
                    break;
                }
            case "xapi":
                {
                   /* _writer = new System.IO.StreamWriter(dataPath + "/" + e.GetPath(), true);
                    //Debug.Log(dataPath + "/");
                    _writer.WriteLine(JsonUtility.ToJson(e));
                    _writer.Close();*/
                    break;
                }
            default:
                {
                   /* _writer = new System.IO.StreamWriter(dataPath + "/" + e.GetPath(), true);
                    //Debug.Log(dataPath + "/");
                    _writer.WriteLine(JsonUtility.ToJson(e));
                    _writer.Close();*/
                    break;
                }
        }
    }
}

