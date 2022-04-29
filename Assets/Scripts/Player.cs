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
            //    print("2���� �̻��� �������� �����ϰ� �ֽ��ϴ�.");
            //}

            //var sword = itemDatas.FirstOrDefault(item => item.itemName == "Sword");

            //if (sword != null)
            //{
            //    print(sword.itemName + ": Lv." + sword.itemLevel);
            //}
            //else
            //{
            //    print("�������� �ʴ� �������Դϴ�.");
            //}

            // ���� �غ���
            //var itemDatasOrderedByLevel =
            //    itemDatas.OrderBy(item => item.itemLevel);

            //foreach (var itemData in itemDatasOrderedByLevel)
            //{
            //    print(itemData.itemName);
            //}

            // ��, �� ��ü �պ� �غ���
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
