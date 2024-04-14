using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatShop : MonoBehaviour
{
    public GameObject EatTab;
    static int iEat;
    public void ShopEat()
    {
        if(ItemShopButton.itemtoken==1)
        {
            if(iEat==0)
            {
                EatTab.transform.position = new Vector3(0, 0, 0);
                iEat = 1;
            } else
            {
                EatTab.transform.position = new Vector3(0, 1000, 0);
                iEat = 0;
            }
        }
    }
}
