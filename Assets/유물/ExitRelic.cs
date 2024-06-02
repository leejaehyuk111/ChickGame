using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitRelic : MonoBehaviour
{
    public SpriteRenderer bimg, bimg2;
    public GameObject relic, BRelic1, BRelic2, BRelic3, BRelic4, BRelic5;
    public SpriteRenderer Relic1, Relic2, Relic3, Relic4, Relic5;

    public void Exit()
    {
        if (ItemShopButton.itemtoken == 2)
        {
            ItemShopButton.itemtoken = 1;
            relic.transform.position = new Vector3(4, -2, 0);
            bimg.transform.position = new Vector3(100, 100, 0);
            bimg2.transform.position = new Vector3(0, 0, 0);
            BRelic1.transform.position = new Vector3(-100, 2.5f, 0);
            BRelic2.transform.position = new Vector3(-100, 2.5f, 0);
            BRelic3.transform.position = new Vector3(-100, 2.5f, 0);
            BRelic4.transform.position = new Vector3(-100, 2.5f, 0);
            BRelic5.transform.position = new Vector3(-100, 2.5f, 0);
            Relic1.transform.position = new Vector3(-100, 2.5f, 0);
            Relic2.transform.position = new Vector3(-100, 2.5f, 0);
            Relic3.transform.position = new Vector3(-100, 2.5f, 0);
            Relic4.transform.position = new Vector3(-100, 2.5f, 0);
            Relic5.transform.position = new Vector3(-100, 2.5f, 0);

        }
    }
}
