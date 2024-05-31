using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeatherN : MonoBehaviour
{
    public static Text feather;
    public static void numRenew()
    {
        feather.text = ChickStatus.feather.ToString();
    }
}
