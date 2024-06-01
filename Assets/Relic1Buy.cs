using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic1Buy : MonoBehaviour
{
    static int i;
    public GameObject BuyTab;
    public SpriteRenderer img,bimg;
    public void buy()
    {
        if (ChickStatus.feather >= 10000 && i == 0 && ItemShopButton.itemtoken == 2)
        {
            ChickStatus2.Relic1 = 1;
            i++;
            ChickStatus.feather -= 10000;
            BuyTab.transform.position = new Vector3(0, 1100, 0);
            img.transform.position = bimg.transform.position + new Vector3 (-7, 2.5f, 0);
        }
    }
}
