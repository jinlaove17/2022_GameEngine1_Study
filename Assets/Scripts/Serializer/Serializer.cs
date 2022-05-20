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
            dataName = "홍길동",
            age = 100,
            height = 1.8f,
            playerPosition = new Vector3(10.0f, 0.0f, 0.0f),
            playerRotation = transform.rotation.eulerAngles,
            someDictionary = new Dictionary<string, int>()
        };

        data.someDictionary.Add("Hi", 10);

        string jsonString = JsonConvert.SerializeObject(data);

        // using scope 안에서 파일 스트림을 열면, 별도로 닫을 필요가 없다.
        using (FileStream fileStream = new FileStream(Path.Combine(Application.persistentDataPath, "save.json"), FileMode.Create))
        {
            byte[] jsonToBytes = Encoding.UTF8.GetBytes(jsonString);

            fileStream.Write(jsonToBytes);
        }

        print(jsonString);
    }
}
