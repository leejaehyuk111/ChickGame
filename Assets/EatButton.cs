using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    static int i;
    public SpriteRenderer curimg;
    public Sprite img1, img2;
    public void OnClickEat()
    {
        if(i== 0)
        {
            curimg.sprite = img1;
            i++;
        }
        else
        {
            curimg.sprite = img2;
            i = 0;
        }
    }
}
