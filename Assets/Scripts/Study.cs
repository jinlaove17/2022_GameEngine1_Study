using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour
{
    private const float m_attackInterval = 3.0f;

    private float m_attackIntervalTimer;

    private void Update()
    {
        m_attackIntervalTimer += Time.deltaTime;

        if (m_attackIntervalTimer >= 3.0f)
        {
            PrintText();
            m_attackIntervalTimer = 0.0f;
        }
    }

    private void PrintText()
    {
        print(message: "Attack!");
    }
}
