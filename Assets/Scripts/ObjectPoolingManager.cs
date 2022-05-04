using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    public ManagedPrefabDatabase prefabDatabase;

    private Dictionary<string, GameObject> prefabDict;
    private Dictionary<string, List<GameObject>> managedObjects;

    private void Awake()
    {
        prefabDict = new Dictionary<string, GameObject>();
        managedObjects = new Dictionary<string, List<GameObject>>();

        // 데이터 베이스를 딕셔너리로 재구성
        foreach (var prefab in prefabDatabase.prefabs)
        {
            prefabDict.Add(prefab.prefabName, prefab.prefabGameObject);
        }
    }

    public GameObject Get(string objectName)
    {
        if (!prefabDict.ContainsKey(objectName))
        {
            return null;
        }
        
        if (!managedObjects.ContainsKey(objectName))
        {
            managedObjects.Add(objectName, new List<GameObject>());
        }

        if (managedObjects[objectName].Any(obj => !obj.activeInHierarchy))
        {
            var possibleObject = managedObjects[objectName].FirstOrDefault(obj => !obj.activeInHierarchy);
            possibleObject.SetActive(true);

            return possibleObject;
        }
        else
        {
            var newObject = Instantiate(prefabDict[objectName]);

            managedObjects[objectName].Add(newObject);

            return newObject;
        }
    }

    public GameObject Get(string objectName, Vector3 position, Quaternion quaternion)
    {
        var go = Get(objectName);

        go.transform.position = position;
        go.transform.rotation = quaternion;

        return go;
    }
}
