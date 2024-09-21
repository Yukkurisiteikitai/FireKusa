using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LodController : MonoBehaviour
{
    public Transform myTransform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myTransform.Rotate(speed, 0, 0,Space.World);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myTransform.Rotate(0, speed, 0, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myTransform.Rotate(0,speed, 0, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myTransform.Rotate(0, -speed, 0, Space.World);
        }

    }
}
