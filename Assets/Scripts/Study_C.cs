using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_C : MonoBehaviour
{
    private void Start()
    {
        var StudyB = transform.parent;
        print(StudyB.name);

        //계층구조를 깨뜨리고 최상단으로 올라라기
        transform.parent = null;
    }
}
