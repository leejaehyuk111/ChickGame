using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyEat4 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if (ChickStatus.feather >= 50000)
        {
            ChickStatus2.fullnessItem += 5f;
            button.interactable = false;
            ChickStatus.feather -= 50000;
        }
    }
}
