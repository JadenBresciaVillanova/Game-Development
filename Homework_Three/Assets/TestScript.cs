using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update

[SerializeField] float xValue = 1;
[SerializeField] float yValue = 0;
[SerializeField] float zValue = 0;
[SerializeField] float moveSpeed = 10f;

    void Start()
    {
        Debug.Log("This happens once on run - Running TestScript");
    }

    // Update is called once per frame
    void Update()
    {
       // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
       // float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yValue = Time.deltaTime * moveSpeed;
        transform.Rotate(0,yValue,0);

        
    }


}
