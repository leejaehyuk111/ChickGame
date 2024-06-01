using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour
{
    int i;
    public SpriteRenderer Merchantshop1, Merchantshop2, Merchantshop3, Merchantshop4, Merchantshop5;
    public GameObject Shop1Tab, Shop2Tab, Shop3Tab, Merchant1, Merchant2, Merchant3;

    public void QuestClear()
    {
        if (ChickStatus2.Q1 == 1)
        {
            Merchantshop1.transform.position = new Vector3(0, 0, 0);
            Merchant1.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
        if (ChickStatus2.Q2 == 1)
        {
            Merchantshop2.transform.position = new Vector3(0, 0, 0);
            Merchant2.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
        if (ChickStatus2.Q3 == 1)
        {
            Merchantshop3.transform.position = new Vector3(0, 0, 0);
            Merchant3.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
        if (ChickStatus2.Q4 == 1)
        {
            Merchantshop4.transform.position = new Vector3(0, 0, 0);
            Merchant1.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
        if (ChickStatus2.Q5 == 1)
        {
            Merchantshop5.transform.position = new Vector3(0, 0, 0);
            Merchant2.transform.position = new Vector3(-3.5f, -0.5f, 0);
        }
    }
}
