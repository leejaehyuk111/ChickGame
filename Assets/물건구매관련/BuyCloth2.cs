using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCloth2 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 5000)
        {
            ChickStatus2.unsleepItem += 1f;
            button.interactable = false;
            ChickStatus.feather -= 5000;
        }
    }
}
