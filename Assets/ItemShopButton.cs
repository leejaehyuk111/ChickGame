using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DreamingButton : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer img1;
    static int i;
    public void MoveBackimg()
    {
        if (i == 0)
        {
            img1.transform.position = new Vector3(0, 0, 0);
            i = 1;        
        }
        else
        {
            img1.transform.position += new Vector3(30, 0, 0);
            i = 0;
        }
    }
}
