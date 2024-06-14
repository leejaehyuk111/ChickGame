using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyJewelry3 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 15000)
        {
            ChickStatus2.divinepowerItem += 2f;
            button.interactable = false;
            ChickStatus.feather -= 15000;
        }
    }
}
