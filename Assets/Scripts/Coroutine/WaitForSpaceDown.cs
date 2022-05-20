using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSpaceDown : MonoBehaviour
{
    private bool isSpaceDowned;

    private void Start()
    {
        StartCoroutine(WaitForSpaceButton());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpaceDowned = true;
        }
    }

    private IEnumerator WaitForSpaceButton()
    {
        print("Press space to start!");

        yield return new WaitUntil(() => isSpaceDowned);

        print("Áö°Ç!!!!!");
    }
}
