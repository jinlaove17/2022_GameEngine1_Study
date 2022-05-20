using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

[Serializable]
public class Data
{
    public string                    dataName;
    public int                       age;
    public float                     height;
    public Vector3                   playerPosition;
    public Vector3                   playerRotation;

    // 유니티에서 제공하는 JsonUntility는 아래와 같은 컨테이너들은 직렬화하지 못한다.
    public Dictionary<string, int> someDictionary;

    // JsonIgnore : 직렬화에서 제외하고 싶은 경우
    [JsonIgnore]
    public Queue<string>           someQueue;
}
