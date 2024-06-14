using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCloth1 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 1000)
        {
            ChickStatus2.unsleepItem += 0.5f;
            button.interactable = false;
            ChickStatus.feather -= 1000;
        }
    }
}
