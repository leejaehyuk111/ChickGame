using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickFether : MonoBehaviour
{
    int i,j,k,l,m,n;

    void Update()
    {
        if (Time.frame >= 95)
        {
            i++;j++;k++;l++;m++;n++;
            if (i>=30)
            {
                i = 0;
                ChickStatus.feather += 1;
            }
        }
    }
}