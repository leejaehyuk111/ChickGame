using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepButton : MonoBehaviour
{
    public void OnClickSleep()
    {
        if (ChickStatus.sleep >= 50)
        {
            ChickStatus.sleep -= 50;
        }
        else
        {
            ChickStatus.sleep = 0;
        }

        Invoke("", 0.5f);
    }
}
