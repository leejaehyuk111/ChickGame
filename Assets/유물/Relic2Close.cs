using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic2Close : MonoBehaviour
{
    public GameObject BuyTab;

    public void Close()
    {
        BuyTab.transform.position = new Vector3(0, 1100, 0);
    }
}
