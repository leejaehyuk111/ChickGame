using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickStatus : MonoBehaviour
{
    public static float fullness, unsleep, clean, divinepower, coin, feather, hp;
    public Slider fullness_bar, unsleep_bar, clean_bar, divinepower_bar, hp_bar;
    public SpriteRenderer img, be, bs, bc, bh, bd;
    public Sprite img1, img2, img3, img4, img5, img6;
    static int walk;
    public static int moving;

    void Update()
    {
        if (Time.frame >= 95)
        {
            if (fullness >= 0)
            {
                fullness -= 1;
                if (fullness <= 100)
                {
                    fullness_bar.value = fullness;
                    be.material.color = Color.white;
                } else if (fullness <= 10000)
                {
                    fullness_bar.value = fullness/100;
                    be.material.color = Color.yellow;
                }
            }
            if (unsleep >= 0)
            {
                unsleep -= 1;
                unsleep_bar.value = unsleep;
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

            if (walk == 0 && fullness >= 30 && moving == 0)
            {
                walk = 1;
                StartCoroutine(move());
                //StopCoroutine(move());
                
            } else if(fullness < 30 && moving == 0)
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
