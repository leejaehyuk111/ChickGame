using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyJewelry1 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 700)
        {
            ChickStatus2.divinepowerItem += 0.5f;
            button.interactable = false;
            ChickStatus.feather -= 700;
        }
    }
}
