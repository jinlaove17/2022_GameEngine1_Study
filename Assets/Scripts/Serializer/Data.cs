using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Data
{
    public string                  dataName;
    public int                     age;
    public float                   height;
    public Vector3                 playerPosition;
    public Quaternion              playerRotation;

    // ����Ƽ���� �����ϴ� JsonUntility�� �Ʒ��� ���� �����̳ʵ��� ����ȭ���� ���Ѵ�.
    //public Dictionary<string, int> someDictionary;
    //public Queue<string>           someQueue;
}
