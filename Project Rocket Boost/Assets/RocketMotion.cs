using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RocketMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Space bar is pushed");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D key is pushed");
        }
    }
}
