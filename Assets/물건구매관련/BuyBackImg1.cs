using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBackImg1 : MonoBehaviour
{
    public Button button;
    public SpriteRenderer img;
    public Sprite bimg;

    public void Buy()
    {
        if (ChickStatus.feather >= 2000)
        {
            ChickStatus2.cleanItem += 0.5f;
            button.interactable = false;
            ChickStatus.feather -= 2000;
            img.sprite = bimg;
        }
    }
}
