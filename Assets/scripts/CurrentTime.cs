using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CurrentTime : MonoBehaviour
{
    [SerializeField] Text time1, time2;
    public int hour = 0;
    public int minute = 0;

    void Start()
    {
        Time_setting();
    }
    void Update()
    {


    }

    public void Time_setting()
    {
        time1.text = DateTime.Now.ToString("HH : mm");
        time2.text = DateTime.Now.ToString("tth : mm");
        hour = DateTime.Now.Hour;
        minute = DateTime.Now.Minute;
    }
}