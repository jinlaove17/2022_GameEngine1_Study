using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_C : MonoBehaviour
{
    private void Start()
    {
        var StudyB = transform.parent;
        print(StudyB.name);

        //���������� ���߸��� �ֻ������ �ö���
        transform.parent = null;
    }
}
