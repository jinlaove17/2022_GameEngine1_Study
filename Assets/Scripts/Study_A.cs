using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_A : MonoBehaviour
{
    private void Start()
    {
        //transform �ȿ� �ִ� ���� ������Ʈ���� �˻��ϱ� ������ GameObject.Find() ���ٴ� ���� ���ϰ� ����
        var StudyB = transform.Find("Study_B");
        print(StudyB.name);
    }
}
