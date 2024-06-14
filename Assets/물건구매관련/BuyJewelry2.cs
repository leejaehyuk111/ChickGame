using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyJewelry2 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 3000)
        {
            ChickStatus2.divinepowerItem += 1f;
            button.interactable = false;
            ChickStatus.feather -= 3000;
        }
    }
}
