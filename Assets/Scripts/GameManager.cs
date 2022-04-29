using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public int coin;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    var go = new GameObject(nameof(GameManager));

                    instance = go.AddComponent<GameManager>();
                }
            }

            return instance;
        }
    }
}
