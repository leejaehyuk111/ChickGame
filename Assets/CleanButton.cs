using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanButton : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer img, bimg;
    public Sprite img1, img2, img3, img4, img5;
    public static int Cleaning;
    
    public void Clean()
    {
        if (MeditationButton.touch == 0 && ItemShopButton.itemtoken == 0)
        {
            if (Cleaning == 0)
            {
                Cleaning = 1;
                bimg.transform.position = new Vector3(0, 0, 0);
                StartCoroutine(clean());

            }
            else
            {
                Cleaning = 0;
                bimg.transform.position = new Vector3(100, 100, 100);
                img.sprite = img1;
            }
        }

    }

    IEnumerator clean()
    {
        while (Cleaning == 1)
        {
            yield return new WaitForSeconds(0.5f);
            ChickStatus.clean += 70*ChickStatus2.cleanItem;
            ChickStatus.hp += 7 * ChickStatus2.fullnessItem;

            if (ChickStatus.clean < 1000)
            {
                img.sprite = img2;
            }
            else if (ChickStatus.clean < 10000)
            {
                img.sprite = img3;
            }
            else if (ChickStatus.clean < 100 * 1000)
            {
                img.sprite = img4;
            }
            else if (ChickStatus.clean < 1000 * 1000)
            {
                img.sprite = img5;
            }
        }
    }
}