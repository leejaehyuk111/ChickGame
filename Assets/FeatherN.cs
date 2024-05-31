using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeatherN : MonoBehaviour
{
    public Text feather;
    void numRenew()
    {
        feather.text = ChickStatus.feather.ToString();
    }
}
