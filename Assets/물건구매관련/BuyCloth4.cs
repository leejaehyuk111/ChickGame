using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCloth4 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 100000)
        {
            ChickStatus2.unsleepItem += 5f;
            button.interactable = false;
            ChickStatus.feather -= 100000;
        }
    }
}
