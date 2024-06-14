using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCloth3 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 20000)
        {
            ChickStatus2.unsleepItem += 2f;
            button.interactable = false;
            ChickStatus.feather -= 20000;
        }
    }
}
