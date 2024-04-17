using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoButton : MonoBehaviour
{
    public Slider Eat, Clean, Sleep, Hp, Divine;
    public GameObject E1, C1, S1, H1, D1;
    static Vector3 e, c, s, h, d, E, C, S, H, D;
    static int infoi;
    public void OnClickInfo()
    {
        if(infoi == 0)
        {
            e = Eat.transform.position;
            c = Clean.transform.position;
            s = Sleep.transform.position;
            h = Hp.transform.position;
            d = Divine.transform.position;
            E = E1.transform.position;
            C = C1.transform.position;
            S = S1.transform.position;
            H = H1.transform.position;
            D = D1.transform.position;
            infoi = 1;
            Eat.transform.position = new Vector3(0, -50, 0);
            Clean.transform.position = new Vector3(0, -50, 0);
            Sleep.transform.position = new Vector3(0, -50, 0);
            Hp.transform.position = new Vector3(0, -50, 0);
            Divine.transform.position = new Vector3(0, -50, 0);
            E1.transform.position = new Vector3(0, -50, 0);
            C1.transform.position = new Vector3(0, -50, 0);
            S1.transform.position = new Vector3(0, -50, 0);
            H1.transform.position = new Vector3(0, -50, 0);
            D1.transform.position = new Vector3(0, -50, 0);


        } else
        {
            Eat.transform.position = e;
            Clean.transform.position = c;
            Sleep.transform.position = s;
            Hp.transform.position = h;
            Divine.transform.position = d;
            infoi = 0;
            E1.transform.position = E;
            C1.transform.position = C;
            S1.transform.position = S;
            H1.transform.position = H;
            D1.transform.position = D;
        }
    }
}
