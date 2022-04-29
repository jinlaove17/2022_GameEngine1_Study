using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.coin += 1;
            var itemDatas = GameManager.Instance.itemDatabase.itemDatas;

            foreach (var itemData in itemDatas)
            {
                print($"{itemData.itemName}: LV.{itemData.itemLevel}");
            }
        }
    }
}
