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
        m_studyBGameObject = new GameObject("Study_B");
        m_studyBGameObject.AddComponent<Study_B>();

        print(m_studyBGameObject.name);

        //var StudyB = m_studyBGameObject.GetComponent<Study_B>();
        //StudyB.SendMessage("SayHello");

        //오브젝트에게 직접 메세지를 보내면 여러 함수를 호출할 수 있음
        //메소드의 이름을 string으로 찾는 과정(reflection)에서 많은 성능 저하가 발생!
        //무겁긴 하지만 잘 사용하면 굉장히 편리하다.
        m_studyBGameObject.SendMessage("SayHello");
        

        Destroy(m_studyBGameObject);
        //Destroy(m_studyBGameObject.GetComponent<Study_B>());
    }
}
