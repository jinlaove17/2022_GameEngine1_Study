using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//abstract: 추상 클래스/컴포넌트로 넣을 수 없게됨
public abstract class Monster : MonoBehaviour
{
    private void Start()
    {
        Cry();
    }

    //자식클래스에서 반드시 override 해주어야 함
    protected abstract void Cry();
}
