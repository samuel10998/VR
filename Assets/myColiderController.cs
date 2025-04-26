using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myColiderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "hand") {
            Color c = GetComponent<Renderer>().material.color;
            if (c == Color.red)
                GetComponent<Renderer>().material.color = Color.blue;
            else
                GetComponent<Renderer>().material.color = Color.red;
        }

    }
}
