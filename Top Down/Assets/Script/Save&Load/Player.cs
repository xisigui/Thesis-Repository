using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public void save()
    {
        SerializationManager.Save(this);
    }


    public void loadData()
    {
        PlayerData playerdata = SerializationManager.Load();
        Vector3 position;
        position.x = playerdata.position[0];
        position.y = playerdata.position[1];
        position.z = playerdata.position[2];

        transform.position = position;
    }
}
