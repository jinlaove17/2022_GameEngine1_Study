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
        print($"{gameObject.name}��(��) {eventName} �̺�Ʈ�� �߻����׽��ϴ�. (�Ű�����: {param})");
    }
}
