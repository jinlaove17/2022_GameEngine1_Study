using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionMapDisplayText : MonoBehaviour
{
    public PlayerInput playerInput = null;
    private TMP_Text text = null;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        text.text = playerInput.currentActionMap.name;
    }
}
