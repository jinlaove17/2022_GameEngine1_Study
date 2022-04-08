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
            panelText.text = "성공적으로 로그인 하였습니다.";
        }
        else
        {
            loginPanel.SetActive(true);
            panelText.text = "아이디 혹은 패스워드가 올바르지 않습니다.";
        }
    }
}
