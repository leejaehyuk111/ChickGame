using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryRight : MonoBehaviour
{
    public SpriteRenderer img;
    public Sprite img1, img2, img3, img4, img5, img6, img7, img8, img9, img10, img11, img12;
    public static int i = 1;
    public Button bt1, bt2;

    public void OnClickRight()
    {
        if (i != 12)
        {
            i++;
        }
        else
        {
            bt1.transform.position = new Vector3(0, 100, 0);
            bt2.transform.position = new Vector3(0, 100, 0);
            img.transform.position = new Vector3(0, 100, 0);
        }

        if (i == 1)
        {
            img.sprite = img1;
        }
        else if (i == 2)
        {
            img.sprite = img2;
        }
        else if (i == 3)
        {
            img.sprite = img3;
        }
        else if (i == 4)
        {
            img.sprite = img4;
        }
        else if (i == 5)
        {
            img.sprite = img5;
        }
        else if (i == 6)
        {
            img.sprite = img6;
        }
        else if (i == 7)
        {
            img.sprite = img7;
        }
        else if (i == 8)
        {
            img.sprite = img8;
        }
        else if (i == 9)
        {
            img.sprite = img9;
        }
        else if (i == 10)
        {
            img.sprite = img10;
        }
        else if (i == 11)
        {
            img.sprite = img11;
        }
        else if (i == 12)
        {
            img.sprite = img12;
        }
    }
}