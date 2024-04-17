using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer curimg;
    public Sprite img1, img2;
    public void OnClickEat()
    {
        ChickStatus.moving = 1;
        
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        curimg.sprite = img1;
        ChickStatus.fullness += 50;
        

        yield return new WaitForSeconds(0.5f);
        curimg.sprite = img2;
        ChickStatus.moving = 0;
    }
}
