using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManeger : MonoBehaviour
{
    public Text bulletCounter_t;
    public Text weedDeleteCounter_t;

    int wd;

    public BulletGenerator bulletGenerator_t;

    public GameObject Result;
    public GameObject help;



    // Start is called before the first frame update
    void Start()
    {
        wd = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }public void PrinteUp()
    {
        Result.SetActive(true);
        int b = bulletGenerator_t.shotCount;

       

        bulletCounter_t.text = b.ToString();
        weedDeleteCounter_t.text = wd.ToString();



        
    }public void UpWeedDeletePoint()
    {
        wd++;
    }
    public void ResetDown()
    {
        Result.SetActive(false);
    }

    public void UpHelp()
    {
        help.SetActive(true);
    }
    public void DownHelp()
    {
        help.SetActive(false);
    }
}
