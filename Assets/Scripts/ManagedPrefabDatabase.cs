using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PrefabDatabase", menuName = "Create Prefab DB", order = 0)]
public class ManagedPrefabDatabase : ScriptableObject
{
    public ManagedPrefab[] prefabs;
}

[Serializable]
public class ManagedPrefab
{
    public string prefabName;
    public GameObject prefabGameObject;
}
