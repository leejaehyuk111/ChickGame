using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantShopC : MonoBehaviour
{
    public GameObject ShopTab;

    public void Close()
    {
        ShopTab.transform.position = new Vector3(0, 1100, 0);
        ClothShop.iCloth = 0;
        BackgroundShop.iBackimg = 0;
        JewelryShop.iJewelry = 0;
        EatShop.iEat = 0;
    }
}
