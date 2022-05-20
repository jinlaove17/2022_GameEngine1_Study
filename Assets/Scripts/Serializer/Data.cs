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

    // ����Ƽ���� �����ϴ� JsonUntility�� �Ʒ��� ���� �����̳ʵ��� ����ȭ���� ���Ѵ�.
    public Dictionary<string, int> someDictionary;

    // JsonIgnore : ����ȭ���� �����ϰ� ���� ���
    [JsonIgnore]
    public Queue<string>           someQueue;
}
