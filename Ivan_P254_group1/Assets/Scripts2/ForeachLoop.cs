using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    public GameObject[] objarray;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject obj in objarray)
        {
            // Destroy(obj);
        }

        GetComponent<ScriptsContro>().score = 90;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
