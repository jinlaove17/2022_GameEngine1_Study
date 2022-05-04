using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Hide", Random.Range(1.0f, 3.0f));
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
