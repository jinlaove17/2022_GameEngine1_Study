using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_A : MonoBehaviour
{
    private GameObject m_studyBGameObject;

    private void Start()
    {
        //성능문제가 발생하기 때문에 캐싱해서 사용하고 웬만하면 Serialization을 권장
        //m_studyBGameObject = GameObject.Find("Study_B");
        m_studyBGameObject = FindObjectOfType<Study_B>().gameObject;
        print(m_studyBGameObject.name);
    }
}
