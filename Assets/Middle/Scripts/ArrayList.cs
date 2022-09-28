using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    public int[] numbers = new int[2];
    public int[] count;

    public List<string> names = new List<string>();

    private void Start()
    {
        foreach (int item in count)
        {
            Debug.Log(item);
        }

        names.Add("Juan");
        names.Add("Javier");
        names.Add("John");
        names.Remove("Juan");

        foreach (string item in names)
        {
            Debug.Log(item);
        }
    }
}
