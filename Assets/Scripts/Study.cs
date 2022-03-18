using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable] // �����Ϳ��� ���� ��������
public class ComplexType
{
    public string m_name;
    public int m_age;
    public float m_height;
}

public class Study : MonoBehaviour
{
    public ComplexType m_studyName;

    private void Start()
    {
        print(message: "������ ���۵Ǿ����ϴ�.");
    }

    private void OnEnable()
    {
        // �� ������Ʈ�� Ȱ��ȭ�� �� ����Ǵ� �Լ�(���� ������Ʈ�� Ȱ��ȭ�Ǵ� ��쿡�� �����)
        print(message: "������Ʈ�� Ȱ��ȭ �Ǿ����ϴ�.");
    }

    private void OnDisable()
    {
        // �� ������Ʈ�� ��Ȱ��ȭ�� �� ����Ǵ� �Լ�(���� ������Ʈ�� ��Ȱ��ȭ�Ǵ� ��쿡�� �����)
        print(message: "������Ʈ�� ��Ȱ��ȭ �Ǿ����ϴ�.");
    }

    private void FixedUpdate()
    {
        // �������� ������ �����ϱ� ���� �ֱ������� ����
        print(message: "������Ʈ�� �ֱ������� ������Ʈ �Ǿ����ϴ�.");
    }

    private void Update()
    {
        print(message: "������Ʈ�� ������Ʈ �Ǿ����ϴ�.");
    }

    private void LateUpdate()
    {
        // UI�� ī�޶� �̵���Ű�ų� ������� �Է��� ���� �� ���
        print(message: "������Ʈ �Ŀ� ����˴ϴ�.");
    }
}
