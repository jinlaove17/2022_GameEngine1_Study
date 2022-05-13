using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public TMP_Text gameOverText;

    public void Start()
    {
        EventManager.Instance.Subscribe("GameOverUI", param =>
        {
            gameOverText.gameObject.SetActive(false);
        });
    }

    public void SetGameOver()
    {
        EventManager.Instance.Emit("GameOver");
        EventManager.Instance.Emit("GameOverUI");
    }
}
