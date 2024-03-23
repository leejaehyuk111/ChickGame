using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Time : MonoBehaviour
{
    public static int Hour, Minute, frame;
    [SerializeField] Text time;
    void Update()
    {
        time.text = Hour + " : " + Minute;
        frame+=25;
        if(frame >= 100)
        {
            frame = 0;
            Minute++;
            if(Minute >= 60)
            {
                Hour++;
                Minute = 0;
                if(Hour >= 24)
                {
                    Hour = 0;
                }
            }
        }

    }
}
