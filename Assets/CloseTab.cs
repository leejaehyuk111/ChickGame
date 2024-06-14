using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseTab : MonoBehaviour
{
    public GameObject Tab;

    public void closeTab()
    {
        Tab.transform.position = new Vector3(100, 0, 0);
    }
}
