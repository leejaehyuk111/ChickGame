using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestButton : MonoBehaviour
{
    public GameObject QButton, QButton2, QButton3, QButton4, QButton5, QButton6, QButton7;
    int i;


    public void Quest()
    {
        if (ChickStatus2.Q5 == 1)
        {
            i = 6;
        } else if(ChickStatus2.Q4 == 1)
        {
            i = 5;
        } else if(ChickStatus2.Q3 == 1)
        {
            i = 4;  
        } else if(ChickStatus2.Q2 == 1)
        {
            i = 3;
        } else if(ChickStatus2.Q1 == 1)
        {
            i = 2;
        } else
        {
            i = 1;
        }

        if(i == 1)
        {
            QButton.transform.position = new Vector3(7, 2, 0);
            QButton2.transform.position = new Vector3(100, 3, 0);
            if (ChickStatus2.Relic1 == 1)
            {
                ChickStatus2.Q1 = 1;
            }
        }
        else if(i == 2)
        {
            QButton2.transform.position = new Vector3(100, 3, 0);
            QButton3.transform.position = new Vector3(7, 2, 0);
            if (ChickStatus2.Relic2 == 1)
            {
                ChickStatus2.Q2 = 1;
            }
        } else if(i == 3)
        {
            QButton3.transform.position = new Vector3(100, 3, 0);
            QButton4.transform.position = new Vector3(7, 2, 0);
            if (ChickStatus2.Relic3 == 1)
            {
                ChickStatus2.Q3 = 1;
            }
        }
        else if (i == 4)
        {
            QButton4.transform.position = new Vector3(100, 3, 0);
            QButton5.transform.position = new Vector3(7, 2, 0);
            if (ChickStatus2.Relic4 == 1)
            {
                ChickStatus2.Q4 = 1;
            }
        }
        else if (i == 5)
        {
            QButton5.transform.position = new Vector3(100, 3, 0);
            QButton6.transform.position = new Vector3(7, 2, 0);
            if (ChickStatus2.Relic5 == 1)
            {
                ChickStatus2.Q5 = 1;
            }
        }
        else if (i == 6)
        {
            QButton6.transform.position = new Vector3(100, 3, 0);
            QButton7.transform.position = new Vector3(7, 2, 0);
        }
    }
}
