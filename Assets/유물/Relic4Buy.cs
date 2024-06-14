using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Relic4Buy : MonoBehaviour
{
    static int i;
    public GameObject BuyTab;
    public SpriteRenderer img, bimg;
    public Button button;

    public void buy()
    {
        if (ChickStatus.feather >= 1000000 && i == 0 && ItemShopButton.itemtoken == 2)
        {
            ChickStatus2.Relic4 = 1;
            i++;
            ChickStatus.feather -= 1000000;
            BuyTab.transform.position = new Vector3(0, 1100, 0);
            img.transform.position = bimg.transform.position + new Vector3(3.3f, 2.5f, 0);
            button.interactable = false;
        }
    }
}
