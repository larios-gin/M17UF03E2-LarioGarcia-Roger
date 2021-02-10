using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLabyrinth : MonoBehaviour
{
    public Vector3 point;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(point, Vector3.up, 20 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
            transform.RotateAround(point, -Vector3.up, 20 * Time.deltaTime);
    }
}
