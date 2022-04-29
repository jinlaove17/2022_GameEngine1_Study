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

            //if (itemDatas.Any(item => item.itemLevel > 1))
            //{
            //    print("2레벨 이상의 아이템을 보유하고 있습니다.");
            //}

            //var sword = itemDatas.FirstOrDefault(item => item.itemName == "Sword");

            //if (sword != null)
            //{
            //    print(sword.itemName + ": Lv." + sword.itemLevel);
            //}
            //else
            //{
            //    print("존재하지 않는 아이템입니다.");
            //}

            // 정렬 해보기
            //var itemDatasOrderedByLevel =
            //    itemDatas.OrderBy(item => item.itemLevel);

            //foreach (var itemData in itemDatasOrderedByLevel)
            //{
            //    print(itemData.itemName);
            //}

            // 앞, 뒤 객체 합병 해보기
            //var itemNames = itemDatas
            //    .Select(item => item.itemName)  
            //    .Aggregate((before, after) => { return before + ", " + after; });

            //print(itemNames);

            var swordDatas = itemDatas
                .Where(item => item.itemName.Contains("Sword"))
                .Select(item => new SwordData
                {
                    itemName = item.itemName,
                    itemLevel = item.itemLevel,
                    attackPower = 10 * item.itemLevel
                });

            foreach (var sword in swordDatas)
            {
                print(sword.itemName + ": Power " + sword.attackPower);
            }
        }
    }
}
