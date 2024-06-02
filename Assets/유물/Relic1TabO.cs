using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic1TabO : MonoBehaviour
{
    public GameObject BuyTab;
    public void move()
    {
        if (ItemShopButton.itemtoken == 2)
        {
            BuyTab.transform.position = new Vector3(0, 0, 0);
        }
    }
}
