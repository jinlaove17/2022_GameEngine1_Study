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
        m_studyBGameObject = new GameObject("Study_B");
        m_studyBGameObject.AddComponent<Study_B>();

        print(m_studyBGameObject.name);

        //var StudyB = m_studyBGameObject.GetComponent<Study_B>();
        //StudyB.SendMessage("SayHello");

        //������Ʈ���� ���� �޼����� ������ ���� �Լ��� ȣ���� �� ����
        //�޼ҵ��� �̸��� string���� ã�� ����(reflection)���� ���� ���� ���ϰ� �߻�!
        //���̱� ������ �� ����ϸ� ������ ���ϴ�.
        m_studyBGameObject.SendMessage("SayHello");
        

        Destroy(m_studyBGameObject);
        //Destroy(m_studyBGameObject.GetComponent<Study_B>());
    }
}
