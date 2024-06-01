using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Relic : MonoBehaviour
{
    public SpriteRenderer bimg,bimg2;
    public GameObject relic, BRelic1, BRelic2, BRelic3, BRelic4, BRelic5;
    public void MoveRelic()
    {
        if (EatShop.iEat == 0 && ItemShopButton.itemtoken == 1)
        {
            ItemShopButton.itemtoken = 2;
            bimg.transform.position = new Vector3(0, 0, 0);
            bimg2.transform.position = new Vector3(100, 100, 0);
            relic.transform.position = new Vector3(0, 30, 0);
            BRelic1.transform.position = bimg.transform.position + new Vector3(-7, 3, 0);
            BRelic2.transform.position = bimg.transform.position + new Vector3(-3.5f, 3, 0);
            BRelic3.transform.position = bimg.transform.position + new Vector3(0, 3, 0);
            BRelic4.transform.position = bimg.transform.position + new Vector3(3.3f, 3, 0);
            BRelic5.transform.position = bimg.transform.position + new Vector3(6.7f, 3, 0);
        }
    }
}
