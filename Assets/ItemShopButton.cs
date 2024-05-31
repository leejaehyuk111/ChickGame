using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopButton : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer img1;
    public GameObject relic;
    public static int itemtoken;
    public void MoveBackimg()
    {
        if (MeditationButton.touch == 0 && CleanButton.Cleaning == 0)
        {
            if (itemtoken == 0)
            {
                relic.transform.position = new Vector3(4, -2, 0);
                img1.transform.position = new Vector3(0, 0, 0);
                itemtoken = 1;
            }
            else if(itemtoken == 1) 
            {
                relic.transform.position = new Vector3(30, 1, 0);
                img1.transform.position += new Vector3(30, 0, 0);
                itemtoken = 0;
            }
        }
    }
}
