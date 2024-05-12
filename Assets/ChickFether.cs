using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickFether : MonoBehaviour
{
    int i, j, k, l, m, n;
    public SpriteRenderer img, featherImg;
    public Sprite img1, img2,img3;

    void Update()
    {
        if (Time.frame >= 95)
        {
            i++; j++; k++; l++; m++; n++;
            if (i >= 30)
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
                    StartCoroutine(Waitfeather());
                }
            }
            if (k >= 120)
            {
                k = 0;
                if (ChickStatus.divinepower >= 200)
                {
                    ChickStatus.feather += 15;
                }
            }
            if (l >= 240)
            {
                l = 0;
                if (ChickStatus.divinepower >= 1000)
                {
                    ChickStatus.feather += 40;
                }
            }
            if (m >= 480)
            {
                m = 0;
                if (ChickStatus.divinepower >= 3000)
                {
                    ChickStatus.feather += 100;
                }
            }
            if (n >= 960)
            {
                n = 0;
                if (ChickStatus.divinepower >= 10000)
                {
                    ChickStatus.feather += 300;
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
    IEnumerator feather1()
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
    IEnumerator feather2()
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
            StartCoroutine(feather1());
        } else
        {
            StartCoroutine(feather2());
        }
    }
}