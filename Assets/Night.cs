using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Night : MonoBehaviour
{
    public SpriteRenderer img;
    // Update is called once per frame
    void Update()
    {
        if (Time.frame >= 75)
        {
            if (Time.Hour <= 6)
            {
                img.transform.position = new Vector3(0, 0, 0);
            }
            else if (Time.Hour <= 18)
            {
                img.transform.position = new Vector3(-25, 0, 0);
            }
            else if (Time.Hour <= 24)
            {
                img.transform.position = new Vector3(0, 0, 0);
            }
        }
    }
}
