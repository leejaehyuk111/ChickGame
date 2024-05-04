using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeditationButton : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer img1;
    public static int touch;

    public void MoveBackimg2()
    {
        
        if(touch == 0)
        {
            touch = 1;
        } else
        {
            touch = 0;
        }
        img1.transform.position = new Vector3(0, 0, 0);
        StartCoroutine(Wait());
        
    }

    IEnumerator Wait()
    {
        while (touch == 1)
        {
            yield return new WaitForSeconds(1f);
        }
        img1.transform.position += new Vector3(50, 0, 0);
    }
}
