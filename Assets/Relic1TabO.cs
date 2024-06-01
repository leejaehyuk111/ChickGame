using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic1TabO : MonoBehaviour
{
    public GameObject BuyTab;
    public void move()
    {
        BuyTab.transform.position = new Vector3(0, 0, 0);
    }
}
