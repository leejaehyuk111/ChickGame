using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour
{
    int i;
    public SpriteRenderer Merchantshop1, Merchantshop2, Merchantshop3, Merchantshop4, Merchantshop5;
    public GameObject Shop1Tab, Shop2Tab, Shop3Tab, Merchant1, Merchant2, Merchant3;
    public int Quest_1_Clear, Quest_2_Clear, Quest_3_Clear, Quest_4_Clear, Quest_5_Clear;

    public void QuestClear()
    {
        if (Quest_1_Clear == 1)
        {
            Merchantshop1.transform.position = new Vector3(0, 0, 0);
            Merchant1.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
        if (Quest_2_Clear == 1)
        {
            Merchantshop2.transform.position = new Vector3(0, 0, 0);
            Merchant2.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
        if (Quest_3_Clear == 1)
        {
            Merchantshop3.transform.position = new Vector3(0, 0, 0);
            Merchant3.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
        if (Quest_4_Clear == 1)
        {
            Merchantshop4.transform.position = new Vector3(0, 0, 0);
            Merchant1.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
        if (Quest_5_Clear == 1)
        {
            Merchantshop5.transform.position = new Vector3(0, 0, 0);
            Merchant2.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
    }
}
