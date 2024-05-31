using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothProduct1 : MonoBehaviour
{
    static int buy;
    public Button iButton;

    public void purchase()
    {
        if (buy == 0 && ChickStatus.feather >= 10)
        {
            iButton.interactable = false;
            buy = 1;
            ChickStatus.feather -= 10;
            ChickStatus2.divinepowerItem += 0.5f;
        }
    }
}
