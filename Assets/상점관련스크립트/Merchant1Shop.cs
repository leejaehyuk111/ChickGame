using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Merchant1Shop : MonoBehaviour
{
    public GameObject ShopTab;
    public static int iShop;
    public void Shop()
    {
        if (iShop == 0)
        {
            ShopTab.transform.position = new Vector3(0, 0, 0);
            iShop = 1;
        }
        else
        {
            ShopTab.transform.position = new Vector3(0, 1100, 0);
            iShop = 0;
        }

    }
}
