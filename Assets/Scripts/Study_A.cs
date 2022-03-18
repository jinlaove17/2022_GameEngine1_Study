using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_A : MonoBehaviour
{
    private void Start()
    {
        //transform 안에 있는 게임 오브젝트만을 검색하기 때문에 GameObject.Find() 보다는 성능 저하가 덜함
        var StudyB = transform.Find("Study_B");
        print(StudyB.name);
    }
}
