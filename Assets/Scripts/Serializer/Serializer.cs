using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

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
            playerRotation = transform.rotation.eulerAngles,
            someDictionary = new Dictionary<string, int>()
        };

        data.someDictionary.Add("Hi", 10);

        string jsonString = JsonConvert.SerializeObject(data);

        // using scope �ȿ��� ���� ��Ʈ���� ����, ������ ���� �ʿ䰡 ����.
        using (FileStream fileStream = new FileStream(Path.Combine(Application.persistentDataPath, "save.json"), FileMode.Create))
        {
            byte[] jsonToBytes = Encoding.UTF8.GetBytes(jsonString);

            fileStream.Write(jsonToBytes);
        }

        print(jsonString);
    }
}
