using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIN_TIME : MonoBehaviour
{

    public GameObject time_obj;
    public int fin_hour = 0;
    public int fin_minute = 0;
    public int fin_5day = 0;



    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    public void Time_FINAL()
    {
        Debug.Log("Time_FINAL");
        fin_hour = time_obj.GetComponent<CurrentTime>().hour;
        Debug.Log(fin_hour);
        fin_minute = GameObject.Find("script").GetComponent<CurrentTime>().minute;
        Debug.Log(fin_minute);
        fin_5day = GameObject.Find("script").GetComponent<CurrentTime>().day_5_int;
        Debug.Log(fin_5day);
    }
}
