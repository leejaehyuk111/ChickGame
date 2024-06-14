using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyEat3 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 10000)
        {
            ChickStatus2.fullnessItem += 2f;
            button.interactable = false;
            ChickStatus.feather -= 10000;
        }
    }
}
