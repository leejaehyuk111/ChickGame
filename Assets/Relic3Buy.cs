using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic3Buy : MonoBehaviour
{
    static int i;
    public GameObject BuyTab;
    public SpriteRenderer img, bimg;
    public void buy()
    {
        if (ChickStatus.feather >= 500000 && i == 0)
        {
            ChickStatus2.Relic3 = 1;
            i++;
            ChickStatus.feather -= 500000;
            BuyTab.transform.position = new Vector3(0, 1100, 0);
            img.transform.position = bimg.transform.position + new Vector3(-0.5f, 2.5f, 0);
        }
    }
}
