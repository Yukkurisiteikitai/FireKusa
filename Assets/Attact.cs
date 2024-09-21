using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attact : MonoBehaviour
{
    public float PowerV;

    public CanvasManeger cm;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        //Vector3 Power = new Vector3(0.0f, PowerV, 0.0f);
        rb.AddForce(transform.forward * PowerV, ForceMode.Impulse);

        cm = GameObject.Find("CanvasManeger").GetComponent<CanvasManeger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "weed")
        {
            Destroy(collision.gameObject);
            cm.UpWeedDeletePoint();


        }
    }
}
