using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepButton : MonoBehaviour
{
    public SpriteRenderer img;
    public Sprite img1, img2;

    public void OnClickSleep()
    {
        img.sprite = img2;
        ChickStatus.moving = 1;

        ChickStatus.unsleep += 50;
        

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        img.sprite = img1;
        ChickStatus.moving = 0;
    }

}
