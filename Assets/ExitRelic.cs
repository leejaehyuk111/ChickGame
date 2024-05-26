using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitRelic : MonoBehaviour
{
    public SpriteRenderer bimg, bimg2;
    public GameObject relic;

    public void Exit()
    {
        if (ItemShopButton.itemtoken == 2)
        {
            ItemShopButton.itemtoken = 1;
            relic.transform.position = new Vector3(4, -2, 0);
            bimg.transform.position = new Vector3(100, 100, 0);
            bimg2.transform.position = new Vector3(0, 0, 0);
            
        }
    }
}
