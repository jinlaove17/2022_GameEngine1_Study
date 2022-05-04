using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    public ObjectPoolingManager poolingManager;

    public void Spawn(string objectName)
    {
        Vector3 position = new Vector3(
            Random.Range(-1.0f, 1.0f),
            Random.Range(-1.0f, 1.0f),
            Random.Range(-1.0f, 1.0f)
            );

        Vector3 rotation = new Vector3(
            Random.Range(-30.0f, 30.0f),
            Random.Range(-30.0f, 30.0f),
            Random.Range(-30.0f, 30.0f)
            );

        poolingManager.Get(objectName, position, Quaternion.Euler(rotation));
    }
}
