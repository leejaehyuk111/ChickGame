using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeditationButton : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer img1;
    public void MoveBackimg2()
    {
        img1.transform.position = new Vector3(0, 0, 0);
        StartCoroutine(Wait());
        
            
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
        img1.transform.position += new Vector3(50, 0, 0);
    }
}
