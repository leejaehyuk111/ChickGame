using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepButton : MonoBehaviour
{
    public SpriteRenderer img1, img2;

    public void OnClickSleep()
    {
        img1.transform.position = new Vector3(100,0, 0);
        img2.transform.position = new Vector3(0, -2.27f, 0);
        if (ChickStatus.sleep >= 50)
        {
            ChickStatus.sleep -= 50;
        }
        else
        {
            ChickStatus.sleep = 0;
        }

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        img1.transform.position = new Vector3(0, -2.27f, 0);
        img2.transform.position = new Vector3(100, 0, 0);
    }

}
