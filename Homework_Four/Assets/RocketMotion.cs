using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RocketMotion : MonoBehaviour
{
    // Start is called before the first frame update
    new Rigidbody rigidbody;
    AudioSource audioSource;
    [SerializeField] float rocketThrust = 100f;
    [SerializeField] float rocketRotation = 1f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddRelativeForce(Vector3.up * rocketThrust * Time.deltaTime);
            audioSource.Play();
        } else
        {
            audioSource.Stop();
        }
    }

    void ProcessRotation() {
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rocketRotation);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * rocketRotation);
        }
    }
}
