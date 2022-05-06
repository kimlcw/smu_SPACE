using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapVIEW : MonoBehaviour
{
    public GameObject mapver;
    public GameObject listver;
    bool hamsu = false;

    // Start is called before the first frame update
    void Start()
    {
        mapver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change_ver()
    {
        if(hamsu == false)
        {
            listver.SetActive(false);
            mapver.SetActive(true);
            hamsu = true;
        }
        else
        {
            listver.SetActive(true);
            mapver.SetActive(false);
            hamsu =false;
        }
        
    }
}
