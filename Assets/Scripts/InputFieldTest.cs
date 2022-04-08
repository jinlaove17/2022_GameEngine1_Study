using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFieldTest : MonoBehaviour
{
    public void OnValueChanged(string str)
    {
        print("text : " + str);
    }
}
