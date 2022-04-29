using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Database", menuName = "Study/Item/Create Item DB", order = 0)]
public class ItemDatabase : ScriptableObject
{
    public ItemData[] itemDatas;
}

[Serializable]
public class ItemData
{
    public string itemName;
    public int itemLevel;

    public Sprite itemThumbnail;
}
