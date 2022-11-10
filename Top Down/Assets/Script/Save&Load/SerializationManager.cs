using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializationManager
{
    public static void Save(Player player)
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
        string path = Application.persistentDataPath + "/saves";
        if(!File.Exists(path))
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
        
        BinaryFormatter formatter = GetBinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);
        PlayerData data = formatter.Deserialize(stream) as PlayerData;
        stream.Close;
        return data;
    }

    public static BinaryFormatter GetBinaryFormatter()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        return formatter;
    }
}
