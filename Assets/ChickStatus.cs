using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickStatus : MonoBehaviour
{
    public static float hungry, sleep, clean, divinepower, coin, feather, hp;
    public Slider hungry_bar, sleep_bar, clean_bar, divinepower_bar, coin_bar, feather_bar, hp_bar;
    
    void Update()
    {
        if (Time.frame >= 75)
        {
            if (hungry <= 100)
            {
                hungry += 1;
                hungry_bar.value = hungry;
            }
            if (sleep <= 100)
            {
                sleep += 1;
                sleep_bar.value = sleep;
            }
            if (clean >= 0)
            {
                clean -= 1;
                clean_bar.value = clean;
            }
            if (divinepower >= 0)
            {
                divinepower -= 1;
                divinepower_bar.value = divinepower;
            }
            if (hp >= 0)
            {
                hp -= 1;
                hp_bar.value = hp;
            }
        }
    }
    
}
