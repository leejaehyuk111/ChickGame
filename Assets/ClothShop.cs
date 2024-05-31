using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothShop : MonoBehaviour
{
    public GameObject ClothTab;
    public static int iCloth;
    public void ShopCloth()
    {
        if (ItemShopButton.itemtoken == 1)
        {
            if (iCloth == 0)
            {
                ClothTab.transform.position = new Vector3(0, 0, 0);
                iCloth = 1;
            }
            else
            {
                ClothTab.transform.position = new Vector3(0, 1000, 0);
                iCloth = 0;
            }
        }
    }
}
