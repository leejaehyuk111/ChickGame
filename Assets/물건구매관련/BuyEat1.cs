using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyEat1 : MonoBehaviour
{
    public Button button;

    public void Buy()
    {
        if(ChickStatus.feather>=500) 
        {
            ChickStatus2.fullnessItem += 0.5f;
            button.interactable = false;
            ChickStatus.feather -= 500;
        }
    }
}
