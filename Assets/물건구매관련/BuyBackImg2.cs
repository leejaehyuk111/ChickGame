using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBackImg2 : MonoBehaviour
{
    public Button button;
    public SpriteRenderer img;
    public Sprite bimg;

    public void Buy()
    {
        if (ChickStatus.feather >= 10000)
        {
            ChickStatus2.cleanItem += 1f;
            button.interactable = false;
            ChickStatus.feather -= 10000;
            img.sprite = bimg;
        }
    }
}
