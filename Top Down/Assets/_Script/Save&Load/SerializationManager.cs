using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializationManager
{
    public static void Save(Player player)
    {
        BinaryFormatter formatter = GetBinaryFormatter();
        string path = Application.persistentDataPath + "/data.dat";   
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData Load()
    {
        string path = Application.persistentDataPath + "/data.dat";

        if(!File.Exists(path))
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }

        BinaryFormatter formatter = GetBinaryFormatter();
        FileStream stream = File.Open(path, FileMode.Open);
        PlayerData data = formatter.Deserialize(stream) as PlayerData;
        stream.Close();
        return data;               
    }

    public static BinaryFormatter GetBinaryFormatter()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        return formatter;
    }
}
