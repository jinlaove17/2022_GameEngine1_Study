using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_A : MonoBehaviour
{
    private GameObject m_studyBGameObject;

    private void Start()
    {
        //���ɹ����� �߻��ϱ� ������ ĳ���ؼ� ����ϰ� �����ϸ� Serialization�� ����
        //m_studyBGameObject = GameObject.Find("Study_B");
        m_studyBGameObject = FindObjectOfType<Study_B>().gameObject;
        print(m_studyBGameObject.name);
    }
}
