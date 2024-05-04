using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickFether : MonoBehaviour
{
    int i, j, k, l, m, n;

    void Update()
    {
        if (Time.frame >= 95)
        {
            i++; j++; k++; l++; m++; n++;
            if (i >= 30)
            {
                i = 0;
                if (ChickStatus.divinepower >= 10)
                {
                    ChickStatus.feather += 1;
                }
            }
            if (j >= 60)
            {
                j = 0;
                if (ChickStatus.divinepower >= 50)
                {
                    ChickStatus.feather += 5;
                }
            }
            if (k >= 120)
            {
                k = 0;
                if (ChickStatus.divinepower >= 200)
                {
                    ChickStatus.feather += 15;
                }
            }
            if (l >= 240)
            {
                l = 0;
                if (ChickStatus.divinepower >= 1000)
                {
                    ChickStatus.feather += 40;
                }
            }
            if (m >= 480)
            {
                m = 0;
                if (ChickStatus.divinepower >= 3000)
                {
                    ChickStatus.feather += 100;
                }
            }
            if (n >= 960)
            {
                n = 0;
                if (ChickStatus.divinepower >= 10000)
                {
                    ChickStatus.feather += 300;
                }
            }
        }
    }
}