using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEmitter : MonoBehaviour
{
    public string eventName = null;
    public int param;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            EventManager.Instance.Emit(eventName, param);
        }
    }
}
