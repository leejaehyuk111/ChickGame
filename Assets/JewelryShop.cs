using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelryShop : MonoBehaviour
{
    public GameObject JewelryTab;
    public static int iJewelry;
    public void ShopJewelry()
    {
        if (ItemShopButton.itemtoken == 1)
        {
            if (iJewelry == 0)
            {
                JewelryTab.transform.position = new Vector3(0, 0, 0);
                iJewelry = 1;
            }
            else
            {
                JewelryTab.transform.position = new Vector3(0, 1000, 0);
                iJewelry = 0;
            }
        }
    }
}
