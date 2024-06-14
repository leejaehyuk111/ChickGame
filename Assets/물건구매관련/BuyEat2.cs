using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyEat2 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 2000)
        {
            ChickStatus2.fullnessItem += 1f;
            button.interactable = false;
            ChickStatus.feather -= 2000;
        }
    }
}
