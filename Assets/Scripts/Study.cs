using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable] // 에디터에서 편집 가능해짐
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
        print(message: "게임이 시작되었습니다.");
    }

    private void OnEnable()
    {
        // 이 컴포넌트가 활성화될 때 실행되는 함수(게임 오브젝트가 활성화되는 경우에도 실행됨)
        print(message: "컴포넌트가 활성화 되었습니다.");
    }

    private void OnDisable()
    {
        // 이 컴포넌트가 비활성화될 때 실행되는 함수(게임 오브젝트가 비활성화되는 경우에도 실행됨)
        print(message: "컴포넌트가 비활성화 되었습니다.");
    }

    private void FixedUpdate()
    {
        // 물리적인 연산을 수행하기 위해 주기적으로 실행
        print(message: "컴포넌트가 주기적으로 업데이트 되었습니다.");
    }

    private void Update()
    {
        print(message: "컴포넌트가 업데이트 되었습니다.");
    }

    private void LateUpdate()
    {
        // UI나 카메라를 이동시키거나 사용자의 입력을 받은 후 사용
        print(message: "업데이트 후에 실행됩니다.");
    }
}
