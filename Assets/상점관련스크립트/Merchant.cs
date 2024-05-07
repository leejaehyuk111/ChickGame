using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour
{
    int i;
    public SpriteRenderer Merchantshop1,Merchantshop2,Merchantshop3;
    public GameObject Shop1Tab, Shop2Tab, Shop3Tab, Merchant1,Merchant2,Merchant3;
    void Update()
    {
        i++;
        if(i >=100)
        {
            i = 0;
            if(Time.Day>=3 && Time.Day<=7)
            {
                if(Time.Hour>=9 && Time.Hour <=21)
                {
                    Merchantshop1.transform.position = new Vector3(0,0,0);
                    Merchant1.transform.position = new Vector3(-3.5f,-0.5f, 0);
                } else
                {
                    Merchantshop1.transform.position = new Vector3(0, 1100, 0);
                    Merchant1.transform.position = new Vector3(0, 1000, 0);
                    if (Merchant1Shop.iShop != 0)
                    {
                        Shop1Tab.transform.position = new Vector3(0, 1000, 0);
                    }
                }
            }
            if (Time.Day >= 11 && Time.Day <= 15)
            {
                if (Time.Hour >= 21 || Time.Hour <= 5)
                {
                    Merchantshop2.transform.position = new Vector3(0, 0, 0);
                    Merchant2.transform.position = new Vector3(-3.5f, -0.5f, 0);
                }
                else
                {
                    Merchantshop2.transform.position = new Vector3(0, 1100, 0);
                    Merchant2.transform.position = new Vector3(0, 1000, 0);
                    if (Merchant2Shop.iShop != 0)
                    {
                        Shop2Tab.transform.position = new Vector3(0, 1000, 0);
                    }
                }
            }
            if (Time.Day >= 23 && Time.Day <= 27)
            {
                if (Time.Hour >= 11 && Time.Hour <= 13 || Time.Hour >= 22 && Time.Hour <= 24)
                {
                    Merchantshop3.transform.position = new Vector3(0, 0, 0);
                    Merchant3.transform.position = new Vector3(-3.5f, -0.5f, 0);
                }
                else
                {
                    Merchantshop3.transform.position = new Vector3(0, 1100, 0);
                    Merchant3.transform.position = new Vector3(0, 1000, 0);
                    if (Merchant3Shop.iShop != 0)
                    {
                        Shop3Tab.transform.position = new Vector3(0, 1000, 0);
                    }
                }
            }
        }
        
    }
}
