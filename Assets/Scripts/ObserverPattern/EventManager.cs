using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private static EventManager instance = null;

    private Dictionary<string, Action<object>> eventDB = null;

    public static EventManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<EventManager>();

                if (instance == null)
                {
                    GameObject newInstance = new GameObject(nameof(EventManager));

                    instance = newInstance.AddComponent<EventManager>();
                }    
            }

            return instance;
        }
    }

    private void Awake()
    {
        eventDB = new Dictionary<string, Action<object>>();
    }

    public void Subscribe(string eventName, Action<object> action)
    {
        if (!eventDB.ContainsKey(eventName))
        {
            eventDB.Add(eventName, action);
        }
        else
        {
            eventDB[eventName] += action;
        }
    }

    public void Emit(string eventName, object param = null)
    {
        if (eventDB.ContainsKey(eventName))
        {
            eventDB[eventName].Invoke(param);
        }
        else
        {
            Debug.LogError("�̺�Ʈ " + eventName + "��(��) �������� �ʽ��ϴ�.");
        }
    }
}
