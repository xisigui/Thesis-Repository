using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializationManager
{
    public static void Save(PlayerMovement player)
    {
        if(!Directory.Exists(Application.persistentDataPath + "/saves"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/saves");
        }

        BinaryFormatter formatter = GetBinaryFormatter();
        string path = Application.persistentDataPath + "/saves";       
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static object Load(string path)
    {
        path = Application.persistentDataPath + "/saves";
        if(!File.Exists(path))
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }

        BinaryFormatter formatter = GetBinaryFormatter();
        FileStream stream = File.Open(path, FileMode.Open);

        try
        {           
            PlayerData data = formatter.Deserialize(stream) as PlayerData;

            stream.Close();
            return data;
        }
        catch
        {
            Debug.LogError("Failed to load data at " + path);
            stream.Close();
            return null;
        }        
    }

    public static BinaryFormatter GetBinaryFormatter()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        return formatter;
    }
}
