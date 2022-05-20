using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using TMPro;

public class SaveFileList : MonoBehaviour
{
    public DataOwner dataOwner = null;
    public Button    loadButtonPrefabs = null;

    private string   SaveFilePath => Application.persistentDataPath;

    private void Start()
    {
        string[] fileNameList = Directory.GetFiles(SaveFilePath);

        foreach (string fileName in fileNameList)
        {
            var loadButton = Instantiate(loadButtonPrefabs, transform);

            loadButton.GetComponentInChildren<TMP_Text>().text = SaveFilePath;

            loadButton.onClick.AddListener(() =>
            {
                var jsonString = File.ReadAllText(Path.Combine(SaveFilePath, fileName));

                dataOwner.SetPlayerData(JsonConvert.DeserializeObject<Data>(jsonString));
            });
        }
    }
}
