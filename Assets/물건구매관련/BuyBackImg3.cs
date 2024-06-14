using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBackImg3 : MonoBehaviour
{
    public Button button;
    public SpriteRenderer img;
    public Sprite bimg;

    public void Buy()
    {
        if (ChickStatus.feather >= 50000)
        {
            ChickStatus2.cleanItem += 2f;
            button.interactable = false;
            ChickStatus.feather -= 50000;
            img.sprite = bimg;
        }
    }
}
