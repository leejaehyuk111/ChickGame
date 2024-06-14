using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBackImg4 : MonoBehaviour
{
    public Button button;
    public SpriteRenderer img;
    public Sprite bimg;

    public void Buy()
    {
        if (ChickStatus.feather >= 300000)
        {
            ChickStatus2.cleanItem += 5f;
            button.interactable = false;
            ChickStatus.feather -= 300000;
            img.sprite = bimg;
        }
    }
}
