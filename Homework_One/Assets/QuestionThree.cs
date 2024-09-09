using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionThree : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float xMove = 0;
    [SerializeField] float yMove = 0;
    [SerializeField] float zMove = 0;
    void Start()
    {
        Debug.Log("I am a component added to the prefab");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I update with every frame of the prefab");
        transform.Translate(xMove,yMove,zMove);
        
    }
}
