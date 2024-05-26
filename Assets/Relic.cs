using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Relic : MonoBehaviour
{
    int Relic1, Relic2, Relic3, Relic4, Relic5;
    public SpriteRenderer bimg,bimg2;
    public GameObject relic;
    public void MoveRelic()
    {
        if (EatShop.iEat == 0 && ItemShopButton.itemtoken == 1)
        {
            ItemShopButton.itemtoken = 2;
            bimg.transform.position = new Vector3(0, 0, 0);
            bimg2.transform.position = new Vector3(100, 100, 0);
            relic.transform.position = new Vector3(0, 30, 0);
        }
    }
}
