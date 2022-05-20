using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText = null;

    //private float   elapsedTime = 0.0f;

    private void Start()
    {
        StartCoroutine(Calculate());
    }

    private void Update()
    {
        //elapsedTime += Time.deltaTime;

        //float flooredTime = Mathf.Floor(elapsedTime);

        //timerText.text = flooredTime.ToString();
        //timerText.text = $"{elapsedTime:00}";
    }

    private IEnumerator Calculate()
    {
        WaitForSeconds waitTime = new WaitForSeconds(1.0f);
        float elapsedTime = 0.0f;
        
        //WaitForSecondsRealtime realWaitTime = new WaitForSecondsRealtime(1.0f);
        //Time.timeScale = 0.5f;

        while (true)
        {
            yield return waitTime;

            elapsedTime += 1.0f;
            timerText.text = elapsedTime.ToString();
        }
    }
}
