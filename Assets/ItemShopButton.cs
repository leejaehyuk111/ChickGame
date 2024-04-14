using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopButton : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer img1;
    public static int itemtoken;
    public void MoveBackimg()
    {
        if (itemtoken == 0)
        {
            img1.transform.position = new Vector3(0, 0, 0);
            itemtoken = 1;        
        }
        else
        {
            img1.transform.position += new Vector3(30, 0, 0);
            itemtoken = 0;
        }
    }
}
