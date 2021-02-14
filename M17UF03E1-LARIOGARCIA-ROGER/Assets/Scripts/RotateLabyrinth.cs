using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLabyrinth : MonoBehaviour
{
    public Vector3 point;
    private float angleOfRotation;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(point, Vector3.forward, 20 * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(point, -Vector3.forward, 20 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(point, Vector3.right, 20 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.RotateAround(point, Vector3.left, 20 * Time.deltaTime);
        }
    }
}
