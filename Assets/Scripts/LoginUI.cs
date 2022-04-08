using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginUI : MonoBehaviour
{
    public TMP_InputField idInputField = null;
    public TMP_InputField pwInputField = null;
    public TMP_Text panelText = null;

    public Button loginButton = null;

    public GameObject loginPanel = null;

    public void Start()
    {
        loginButton.onClick.AddListener(OnClickButton);
    }

    public void OnClickButton()
    {
        if (idInputField.text == "adin" && pwInputField.text == "123456")
        {
            loginPanel.SetActive(true);
            panelText.text = "���������� �α��� �Ͽ����ϴ�.";
        }
        else
        {
            loginPanel.SetActive(true);
            panelText.text = "���̵� Ȥ�� �н����尡 �ùٸ��� �ʽ��ϴ�.";
        }
    }
}
