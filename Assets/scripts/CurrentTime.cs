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
    public Dropdown Drd_5day;
    public int day_5_int = 0;



    void Start()
    {
        Time_setting();


    }
    void Update()
    {
        hour = Drd_Hour.value + 8;
        minute = Drd_Min.value;
        day_5_int = Drd_5day.value;
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


        if(DateTime.Now.DayOfWeek == DayOfWeek.Monday)
        {
            day_5_int = 0;
            Drd_5day.value = 0;
        }
        if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
        {
            day_5_int = 1;
            Drd_5day.value = 1;
        }
        if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
        {
            day_5_int = 2;
            Drd_5day.value = 2;
        }
        if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
        {
            day_5_int = 3;
            Drd_5day.value = 3;
        }
        if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
        {
            day_5_int = 4;
            Drd_5day.value = 4;
        }
        if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
        {
            day_5_int = 4;
            Drd_5day.value = 4;
        }
        //Drd_Hour.value = day;

    }
}