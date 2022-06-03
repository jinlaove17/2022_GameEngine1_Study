using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public int count;
    public Mesh mesh;
    public Material[] materials;

    private List<List<Matrix4x4>> matriceList;

    private void Start()
    {
        matriceList = new List<List<Matrix4x4>>();

        int addedMatrixCount = 0;

        for (int i = 0; i < count; ++i)
        {
            if (addedMatrixCount < 1000 && matriceList.Count != 0)
            { 
                matriceList[matriceList.Count - 1].Add(Matrix4x4.TRS(new Vector3(Random.Range(-50.0f, 50.0f), Random.Range(-50.0f, 50.0f), Random.Range(-50.0f, 50.0f)), Quaternion.identity, Vector3.one));
                addedMatrixCount += 1;
            }
            else
            {
                matriceList.Add(new List<Matrix4x4>());
                addedMatrixCount = 0;
            }
        }
    }

    private void Update()
    {
        foreach (var matrixList in matriceList)
        {
            for (int i = 0; i < mesh.subMeshCount; ++i)
            {
                Graphics.DrawMeshInstanced(mesh, i, materials[i], matrixList);
            }
        }
    }
}
