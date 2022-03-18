using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//abstract: �߻� Ŭ����/������Ʈ�� ���� �� ���Ե�
public abstract class Monster : MonoBehaviour
{
    private void Start()
    {
        Cry();
    }

    //�ڽ�Ŭ�������� �ݵ�� override ���־�� ��
    protected abstract void Cry();
}
