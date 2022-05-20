using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serializer : MonoBehaviour
{
    private void Start()
    {
        Data data = new Data
        {
            dataName = "ȫ�浿",
            age = 100,
            height = 1.8f,
            playerPosition = new Vector3(10.0f, 0.0f, 0.0f),
            playerRotation = Quaternion.Euler(10.0f, 20.0f, 30.0f)
        };

        string jsonString = JsonUtility.ToJson(data);

        print(jsonString);
    }
}
