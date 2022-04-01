using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleActionMap : MonoBehaviour
{
    public PlayerInput playerInput = null;

    public void ToggleMap()
    {
        if (playerInput.currentActionMap.name == "Game")
        {
            playerInput.SwitchCurrentActionMap("UI");
        }
        else
        {
            playerInput.SwitchCurrentActionMap("Game");
        }
    }
}
