using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Soy un mensaje");
        Debug.LogWarning("Me estoy acercando al final");
        Debug.LogError("Hay un error");

        for (int i = 0; i < 10; i++)
        {
            Debug.LogFormat($"<color=blue> {i} </color>");
        }
    }
}
