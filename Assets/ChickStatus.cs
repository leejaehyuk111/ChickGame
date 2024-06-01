using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickStatus : MonoBehaviour
{
    public static float fullness, unsleep, clean, divinepower, hp;
    public static int coin, feather = 10000;
    public Slider fullness_bar, unsleep_bar, clean_bar, divinepower_bar, hp_bar;
    public SpriteRenderer img, be, bs, bc, bh, bd;
    public Sprite img1, img2, img3, img4, img5, img6, be0, be1, be2, be3, be4, be5, bs0, bs1, bs2, bs3, bs4, bs5, bc0, bc1, bc2, bc3, bc4, bc5, bh0, bh1, bh2, bh3, bh4, bh5, bd0, bd1, bd2, bd3, bd4, bd5;
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
                    be.sprite = be0;
                } else if (fullness <= 10000)
                {
                    fullness_bar.value = fullness/100;
                    be.sprite = be1;
                }
                else if (fullness <= 100 * 100 * 100)
                {
                    fullness_bar.value = fullness / 100 * 100;
                    be.sprite = be2;
                }
                else if (fullness <= 100 * 100 * 100 * 100)
                {
                    fullness_bar.value = fullness / 100 * 100 * 100;
                    be.sprite = be3;
                }
                /*     else if (fullness <= 100 * 100 * 100 * 100 * 100)
                     {
                         fullness_bar.value = fullness / 100 * 100 * 100 * 100;
                         be.sprite = be4;
                     }
                     else if (fullness <= 100 * 100 * 100 * 100 * 100 * 100)
                     {
                         fullness_bar.value = fullness / 100 * 100 * 100 * 100 * 100;
                         be.sprite = be5;
                     }
                */
            }
            if (unsleep >= 0)
            {
                unsleep -= 1;
                if (unsleep <= 100)
                {
                    unsleep_bar.value = unsleep;
                    bs.sprite = bs0;
                }
                else if (unsleep <= 10000)
                {
                    unsleep_bar.value = unsleep / 100;
                    bs.sprite = bs1;
                }
                else if (unsleep <= 100 * 100 * 100)
                {
                    unsleep_bar.value = unsleep / 10000;
                    bs.sprite = bs2;
                }
                else if (unsleep <= 100 * 100 * 100 * 100)
                {
                    unsleep_bar.value = unsleep / 100 * 100 * 100;
                    bs.sprite = bs3;
                }
                /*        else if (unsleep <= 100 * 100 * 100 * 100 * 100)
                        {
                            unsleep_bar.value = unsleep / 100 * 100 * 100 * 100;
                            bs.sprite = bs4;
                        }
                        else if (unsleep <= 100 * 100 * 100 * 100 * 100 * 100)
                        {
                            unsleep_bar.value = unsleep / 100 * 100 * 100 * 100 * 100;
                            bs.sprite = bs5;
                        }
                  */
            }
            if (clean >= 0)
            {
                clean -= 1;
                if (clean <= 100)
                {
                    clean_bar.value = clean;
                    bc.sprite = bc0;
                }
                else if (clean <= 10000)
                {
                    clean_bar.value = clean / 100;
                    bc.sprite = bc1;
                }
                else if (clean <= 100 * 100 * 100)
                {
                    clean_bar.value = clean / 10000;
                    bc.sprite = bc2;
                }
                else if (clean <= 100 * 100 * 100 * 100)
                {
                    clean_bar.value = clean / 100 * 100 * 100;
                    bc.sprite = bc3;
                }
                /*       else if (clean <= 100 * 100 * 100 * 100 * 100)
                       {
                           clean_bar.value = clean / 100 * 100 * 100 * 100;
                           bc.sprite = bc4;
                       }
                       else if (clean <= 100 * 100 * 100 * 100 * 100 * 100)
                       {
                           clean_bar.value = clean / 100 * 100 * 100 * 100 * 100;
                           bc.sprite = bc5;
                       }
                 */
            }
            if (divinepower >= 0)
            {
                divinepower -= 1;
                if (divinepower <= 100)
                {
                    divinepower_bar.value = divinepower;
                    bd.sprite = bd0;
                }
                else if (divinepower <= 10000)
                {
                    divinepower_bar.value = divinepower / 100;
                    bd.sprite = bd1;
                }
                else if (divinepower <= 100 * 100 * 100)
                {
                    divinepower_bar.value = divinepower / 10000;
                    bd.sprite = bd2;
                }
                else if (clean <= 100 * 100 * 100 * 100)
                {
                    divinepower_bar.value = divinepower / 100 * 100 * 100;
                    bd.sprite = bd3;
                }
                /*       else if (divinepower <= 100 * 100 * 100 * 100 * 100)
                       {
                           divinepower_bar.value = divinepower / 100 * 100 * 100 * 100;
                           bd.sprite = bd4;
                       }
                       else if (divinepower <= 100 * 100 * 100 * 100 * 100 * 100)
                       {
                           divinepower_bar.value = divinepower / 100 * 100 * 100 * 100 * 100;
                           bd.sprite = bd5;
                       }
                 */
            }
            if (hp >= 0)
            {
                if (hp <= 100)
                {
                    hp_bar.value = hp;
                    bh.sprite = bh0;
                }
                else if (hp <= 10000)
                {
                    hp_bar.value = hp / 100;
                    bh.sprite = bh1;
                }
                else if (hp <= 100 * 100 * 100)
                {
                    hp_bar.value = hp / 10000;
                    bh.sprite = bh2;
                }
                else if (hp <= 100 * 100 * 100 * 100)
                {
                    hp_bar.value = hp / 100 * 100 * 100;
                    bh.sprite = bh3;
                }
                /*       else if (hp <= 100 * 100 * 100 * 100 * 100)
                       {
                           hp_bar.value = hp / 100 * 100 * 100 * 100;
                           bh.sprite = bh4;
                       }
                       else if (hp <= 100 * 100 * 100 * 100 * 100 * 100)
                       {
                           hp_bar.value = hp / 100 * 100 * 100 * 100 * 100;
                           bh.sprite = bh5;
                       }
                 */
            }

            if (walk == 0 && fullness >= 30 && moving == 0 && CleanButton.Cleaning == 0)
            {
                walk = 1;
                StartCoroutine(move());
                
            } else if(fullness < 30 && moving == 0 && CleanButton.Cleaning == 0)
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