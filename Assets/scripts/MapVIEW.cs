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

    public void map_view()
    {
        if(hamsu == false)
        {
            listver.SetActive(false);
            mapver.SetActive(true);
            hamsu = true;
        }
             
    }

    public void map_close()
    {

            listver.SetActive(true);
            mapver.SetActive(false);
            hamsu = false;

    }
}
