using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serializer : MonoBehaviour
{
    private void Start()
    {
        //PlayerPrefs.SetInt("Test", 1000);

        print(PlayerPrefs.GetInt("Test"));
    }
}
