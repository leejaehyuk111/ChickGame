using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickStatus : MonoBehaviour
{
    public static float hungry, sleep, clean, divinepower, coin, feather, hp;
    public SpriteRenderer hungry_bar, sleep_bar, clean_bar, divinepower_bar, coin_bar, feather_bar, hp_bar;
    void Update()
    {
        if (Time.frame >= 75)
        {
            if (hungry <= 100)
            {
                hungry += 1;
                hungry_bar.transform.localScale = new Vector3(hungry/100 * (float)0.75, (float)0.25, 0);
                //hungry_bar.transform.position = new Vector3((float)-8.5 + hungry_bar.transform.localScale.x / 2, (float)1.36, 0);
            }
            if (sleep <= 100)
            {
                sleep += 1;
            }
            if (clean >= 0)
            {
                clean -= 1;
            }
            if (divinepower >= 0)
            {
                divinepower -= 1;
            }
            if (hp >= 0)
            {
                hp -= 1;
            }
        }
    }
}
