using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class SaveButton : MonoBehaviour
{
    public DataOwner dataOwner;
    public string saveFileName = "saveFile.json";

    private string saveFilePath => Application.persistentDataPath;

    public void SaveNewFile()
    {
        string jsonString = JsonConvert.SerializeObject(dataOwner.data);

        File.WriteAllText(Path.Combine(saveFilePath, saveFileName), jsonString);
    }
}
