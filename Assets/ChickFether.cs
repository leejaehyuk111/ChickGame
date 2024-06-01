using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickFether : MonoBehaviour
{
    int i, j, k, l, m, n;
    public SpriteRenderer img, featherImg, featherImg2, featherImg3, featherImg4, featherImg5, featherImg6;
    public Sprite img1, img2,img3;
    public Text feather;

    void Update()
    {
        if (Time.frame >= 95)
        {
            i++; j++; k++; l++; m++; n++;
            feather.text = ChickStatus.feather.ToString();
            if (i >= 60)
            {
                i = 0;
                if (ChickStatus.divinepower >= 10)
                {
                    ChickStatus.feather += 1;
                    img.sprite = img2;
                    StartCoroutine(Waitfeather());
                }
            }
            if (j >= 60)
            {
                j = 0;
                if (ChickStatus.divinepower >= 50)
                {
                    ChickStatus.feather += 5;
                    StartCoroutine(Waitfeather2());
                }
            }
            if (k >= 120)
            {
                k = 0;
                if (ChickStatus.divinepower >= 200)
                {
                    ChickStatus.feather += 15;
                    StartCoroutine(Waitfeather3());
                }
            }
            if (l >= 240)
            {
                l = 0;
                if (ChickStatus.divinepower >= 1000)
                {
                    ChickStatus.feather += 40;
                    StartCoroutine(Waitfeather4());
                }
            }
            if (m >= 480)
            {
                m = 0;
                if (ChickStatus.divinepower >= 3000)
                {
                    ChickStatus.feather += 100;
                    StartCoroutine(Waitfeather5());
                }
            }
            if (n >= 960)
            {
                n = 0;
                if (ChickStatus.divinepower >= 10000)
                {
                    ChickStatus.feather += 300;
                    StartCoroutine(Waitfeather6());
                }
            }
        }
    }
    IEnumerator Waitfeather()
    {
        yield return new WaitForSeconds(0.5f);
        img.sprite = img3;
        yield return new WaitForSeconds(0.5f);
        img.sprite = img1;
        createFeather();
    }
    IEnumerator Waitfeather2()
    {
        yield return new WaitForSeconds(0.5f);
        img.sprite = img3;
        yield return new WaitForSeconds(0.5f);
        img.sprite = img1;
        createFeather2();
    }
    IEnumerator Waitfeather3()
    {
        yield return new WaitForSeconds(0.5f);
        img.sprite = img3;
        yield return new WaitForSeconds(0.5f);
        img.sprite = img1;
        createFeather3();
    }
    IEnumerator Waitfeather4()
    {
        yield return new WaitForSeconds(0.5f);
        img.sprite = img3;
        yield return new WaitForSeconds(0.5f);
        img.sprite = img1;
        createFeather4();
    }
    IEnumerator Waitfeather5()
    {
        yield return new WaitForSeconds(0.5f);
        img.sprite = img3;
        yield return new WaitForSeconds(0.5f);
        img.sprite = img1;
        createFeather5();
    }
    IEnumerator Waitfeather6()
    {
        yield return new WaitForSeconds(0.5f);
        img.sprite = img3;
        yield return new WaitForSeconds(0.5f);
        img.sprite = img1;
        createFeather6();
    }
    IEnumerator feather1(SpriteRenderer featherImg)
    {
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(0.5f, -0.2f);
        yield return new WaitForSeconds(3f);
        featherImg.transform.position += new Vector3(-50, -50);
    }
    IEnumerator feather2(SpriteRenderer featherImg)
    {
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.1f, 0.4f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(0.2f);
        featherImg.transform.position += new Vector3(-0.5f, -0.2f);
        yield return new WaitForSeconds(3f);
        featherImg.transform.position += new Vector3(-50, -50);
    }
    void createFeather()
    {
        
        featherImg.transform.position = img.transform.position;
        if (Random.Range(0,2)==0)
        {
            StartCoroutine(feather1(featherImg));
        } else
        {
            StartCoroutine(feather2(featherImg));
        }
    }
    void createFeather2()
    {

        featherImg2.transform.position = img.transform.position;
        if (Random.Range(0, 2) == 0)
        {
            StartCoroutine(feather1(featherImg2));
        }
        else
        {
            StartCoroutine(feather2(featherImg2));
        }
    }
    void createFeather3()
    {

        featherImg3.transform.position = img.transform.position;
        if (Random.Range(0, 2) == 0)
        {
            StartCoroutine(feather1(featherImg3));
        }
        else
        {
            StartCoroutine(feather2(featherImg3));
        }
    }
    void createFeather4()
    {

        featherImg4.transform.position = img.transform.position;
        if (Random.Range(0, 2) == 0)
        {
            StartCoroutine(feather1(featherImg4));
        }
        else
        {
            StartCoroutine(feather2(featherImg4));
        }
    }
    void createFeather5()
    {

        featherImg5.transform.position = img.transform.position;
        if (Random.Range(0, 2) == 0)
        {
            StartCoroutine(feather1(featherImg5));
        }
        else
        {
            StartCoroutine(feather2(featherImg5));
        }
    }
    void createFeather6()
    {

        featherImg6.transform.position = img.transform.position;
        if (Random.Range(0, 2) == 0)
        {
            StartCoroutine(feather1(featherImg6));
        }
        else
        {
            StartCoroutine(feather2(featherImg6));
        }
    }
}