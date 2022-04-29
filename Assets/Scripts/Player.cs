using System.Linq;
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

            // Linq - Code Chaining ¹æ½Ä
            var itemLowerThan3 =
                itemDatas.Where(item => item.itemLevel < 3)
                         .Select(item => item.itemName);

                //from item in itemDatas
                //where item.itemLevel < 3
                //select item.itemName;

            foreach (var itemName in itemLowerThan3)
            {
                print(itemName);
            }
        }
    }
}
