using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour
{
    private void Start()
    {
        //Update�� �ٸ��� GameObject�� ��Ȱ��ȭ ���¿��� �����
        //Invoke("PrintText", 3.0f);
        InvokeRepeating("PrintText", 0.0f, 3.0f);
    }

    private void PrintText()
    {
        print("Attack!");
    }
}
