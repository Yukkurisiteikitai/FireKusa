using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public GameObject Shot;
    public float spead;
    public Transform point;
    Vector3 IO;

    


    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            IO = point.position;
            Instantiate(Shot,IO,Quaternion.identity);
        }
    }
}
