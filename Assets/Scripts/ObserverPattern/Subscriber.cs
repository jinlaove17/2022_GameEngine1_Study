using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    public string eventName = null;

    private void Start()
    {
        EventManager.Instance.Subscribe(eventName, OnEvent);
    }

    private void OnEvent(object param)
    {
        print($"{gameObject.name}이(가) {eventName} 이벤트를 발생시켰습니다. (매개변수: {param})");
    }
}
