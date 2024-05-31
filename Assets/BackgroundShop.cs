using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundShop : MonoBehaviour
{
    public GameObject BackimgTab;
    public static int iBackimg;
    public void ShopBack()
    {
        if (ItemShopButton.itemtoken == 1)
        {
            if (iBackimg == 0)
            {
                BackimgTab.transform.position = new Vector3(0, 0, 0);
                iBackimg = 1;
            }
            else
            {
                BackimgTab.transform.position = new Vector3(0, 1000, 0);
                iBackimg = 0;
            }
        }
    }
}
