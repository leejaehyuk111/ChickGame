using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickStatus : MonoBehaviour
{
    public static float hungry, sleep, clean, divinepower, coin, feather, hp;
    public Slider hungry_bar, sleep_bar, clean_bar, divinepower_bar, coin_bar, feather_bar, hp_bar;
    public SpriteRenderer img;
    public Sprite img1, img2,img3,img4,img5,img6;
    static int walk;

    void Update()
    {
        if (Time.frame >= 95)
        {
            if (hungry <= 100)
            {
                hungry += 1;
                hungry_bar.value = hungry;
            }
            if (sleep <= 100)
            {
                sleep += 1;
                sleep_bar.value = sleep;
            }
            if (clean >= 0)
            {
                clean -= 1;
                clean_bar.value = clean;
            }
            if (divinepower >= 0)
            {
                divinepower -= 1;
                divinepower_bar.value = divinepower;
            }
            if (hp >= 0)
            {
                hp -= 1;
                hp_bar.value = hp;
            }

            if (walk == 0 && hungry <= 70)
            {
                walk = 1;
                StartCoroutine(move());
                //StopCoroutine(move());
                
            } else if(hungry > 70)
            {
                img.sprite = img6;
                img.transform.position = new Vector3(0, -2.27f,0);
            }

        }
    }

    IEnumerator move()
    {
        yield return new WaitForSeconds(1);
        img.sprite = img2;
        img.transform.position += new Vector3(0.5f, 0, 0);
        yield return new WaitForSeconds(1);
        img.sprite = img3;
        img.transform.position += new Vector3(0.5f, 0, 0);
        yield return new WaitForSeconds(1);
        img.sprite = img2;
        img.transform.position -= new Vector3(0.5f, 0, 0);
        yield return new WaitForSeconds(1);
        img.sprite = img1;
        img.transform.position -= new Vector3(0.5f, 0, 0);
        yield return new WaitForSeconds(1);
        img.sprite = img4;
        img.transform.position -= new Vector3(0.5f, 0, 0);
        yield return new WaitForSeconds(1);
        img.sprite = img5;
        img.transform.position -= new Vector3(0.5f, 0, 0);
        yield return new WaitForSeconds(1);
        img.sprite = img4;
        img.transform.position += new Vector3(0.5f, 0, 0);
        yield return new WaitForSeconds(1);
        img.sprite = img1;
        img.transform.position += new Vector3(0.5f, 0, 0);
        yield return new WaitForSeconds(1);
        walk = 0;
    }
}
