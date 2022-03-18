using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour
{
    private void Start()
    {
        //Update와 다르게 GameObject가 비활성화 상태여도 실행됨
        //Invoke("PrintText", 3.0f);
        InvokeRepeating("PrintText", 0.0f, 3.0f);
    }

    private void PrintText()
    {
        print("Attack!");
    }
}
