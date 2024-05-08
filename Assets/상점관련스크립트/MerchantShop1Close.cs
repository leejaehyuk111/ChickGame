using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantShop1Close : MonoBehaviour
{
    public GameObject ShopTab;

    public void Close()
    {
        ShopTab.transform.position = new Vector3(0, 1100, 0);
    }
}
