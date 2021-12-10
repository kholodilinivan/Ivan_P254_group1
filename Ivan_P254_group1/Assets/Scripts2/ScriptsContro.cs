using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptsContro : MonoBehaviour
{
    public int score = 10;
    // Start is called before the first frame update
    void Start()
    {
        // Create public int variable “score” in one script and change it from another script(both scripts are attached to a similar game object)

        // Create a new script “ColorControl” attach it to a different game obejct and change color of this game object
        GameObject.Find("Capsule").GetComponent<Renderer>().material.color = Color.yellow;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
