using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public Rigidbody cubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            cubo.AddForce(50, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cubo.AddForce(0, -50, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cubo.AddForce(-50, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            cubo.AddForce(0, 50, 0);
        }
    }
}
