using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic2Buy : MonoBehaviour
{
    static int i;
    public GameObject BuyTab;
    public SpriteRenderer img, bimg;
    public void buy()
    {
        if (ChickStatus.feather >= 100000 && i == 0)
        {
            ChickStatus2.Relic2 = 1;
            i++;
            ChickStatus.feather -= 100000;
            BuyTab.transform.position = new Vector3(0, 1100, 0);
            img.transform.position = bimg.transform.position + new Vector3(-3, 2.5f, 0);
        }
    }
}
