using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayWork : MonoBehaviour
{
    public int[] numbers;
    public string[] names;
    public GameObject[] gameobj;
    public Color[] color;

    // Start is called before the first frame update
    void Start()
    {
        // int with index 2, string with index 0 in Start()
        print(numbers[2]);
        print(names[0]);

        //assign gameobject with index 1 by the color with index 2
        gameobj[1].GetComponent<Renderer>().material.color = color[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
