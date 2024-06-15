using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryLeft : MonoBehaviour
{
    public SpriteRenderer img;
    public Sprite img1, img2, img3, img4, img5, img6, img7, img8, img9, img10, img11, img12;
    
    void Start()
    {
        img.transform.position = new Vector3(0, 0, 0);
    }

    public void OnClickLeft()
    {
        if(StoryRight.i == 0)
        {
            StoryRight.i++;
        } else
        {
            StoryRight.i--;
        }

        if(StoryRight.i == 1)
        {
            img.sprite = img1;
        } else if(StoryRight.i == 2)
        {
            img.sprite = img2;
        } else if(StoryRight.i == 3)
        {
            img.sprite = img3;
        } else if (StoryRight.i == 4)
        {
            img.sprite = img4;
        } else if (StoryRight.i == 5)
        {
            img.sprite = img5;
        } else if (StoryRight.i == 6)
        {
            img.sprite = img6;
        } else if (StoryRight.i == 7)
        {
            img.sprite = img7;
        } else if (StoryRight.i == 8)
        {
            img.sprite = img8;
        } else if (StoryRight.i == 9)
        {
            img.sprite = img9;
        } else if (StoryRight.i == 10)
        {
            img.sprite = img10;
        } else if (StoryRight.i == 11)
        {
            img.sprite = img11;
        } else if (StoryRight.i == 12)
        {
            img.sprite = img12;
        }

    }

}
