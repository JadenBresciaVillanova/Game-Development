using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw2 : MonoBehaviour
{
   
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
