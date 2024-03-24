using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeditationButton : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer img1;
    static int j;
    public void MoveBackimg2()
    {
        if (j == 0)
        {
            img1.transform.position = new Vector3(0, 0, 0);
            j = 1;
        }
        else
        {
            img1.transform.position += new Vector3(50, 0, 0);
            j = 0;
        }
    }
}
