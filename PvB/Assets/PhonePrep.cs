using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhonePrep : MonoBehaviour
{
    void Awake()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
