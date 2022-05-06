using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CurrentTime : MonoBehaviour
{
    [SerializeField] //Text time1, time2;
    public int hour = 0;
    public int minute = 0;
    public Dropdown Drd_Hour;
    public Dropdown Drd_Min;

    void Start()
    {
        Time_setting();


    }
    void Update()
    {
        hour = Drd_Hour.value + 8;
        minute = Drd_Min.value;
    }

    public void Time_setting()
    {
        //time1.text = DateTime.Now.ToString("HH : mm");
        //time2.text = DateTime.Now.ToString("tth : mm");
        hour = DateTime.Now.Hour;
        //time1.text = hour.ToString();
        Drd_Hour.value = hour - 8;

        minute = DateTime.Now.Minute;
        //time2.text = minute.ToString();
        Drd_Min.value = minute;
    }
}