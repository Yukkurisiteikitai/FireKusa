using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeedMan : MonoBehaviour
{
    public GameObject weed;
    public int MakerValue;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < MakerValue; i++)
        {
            Instantiate(weed, new Vector3(RandomReturn(-24.8f, 25.79f), -4.12f, RandomReturn(-22.03f, 30.97f)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Joi(10);
        }
    }
    float RandomReturn(float mix,float max)
    {
        return Random.Range(mix,max);
    }
    void Joi(int counter)
    {
        for (int i = 0; i < counter; i++)
        {
            Instantiate(weed, new Vector3(RandomReturn(-24.8f, 25.79f), -4.12f, RandomReturn(-22.03f, 30.97f)), Quaternion.identity);
        }
    }
}
