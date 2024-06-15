using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelicTabO : MonoBehaviour
{
    public GameObject Object;

    public void openTab()
    {
        if (ItemShopButton.itemtoken == 2)
        {
            Object.transform.position = new Vector3(0, 0, 0);
        }
    }
}
