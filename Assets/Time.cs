using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Time : MonoBehaviour
{
    public static int Day = 1, Hour=9, Minute, frame;
    [SerializeField] Text time;
    void Start()
    {
        time.text = Hour + " : " + Minute;
    }
    
    void Update()
    {
        frame+=2;
        if(frame >= 100)
        {
            time.text = Day + " : " + Hour + " : " + Minute;
            frame = 0;
            Minute++;
            if(Minute >= 60)
            {
                Hour++;
                Minute = 0;
                if(Hour >= 24)
                {
                    Day++;
                    Hour = 0;
                    if(Day >30)
                    {
                        Day = 1;
                    }
                }
            }
        }

    }
}
