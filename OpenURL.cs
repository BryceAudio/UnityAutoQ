using UnityEngine;
using System.Collections;

public class OpenURL : MonoBehaviour
{


    void Start() //this wouldn't be in Start - stick this in your 'end game' script.
                   // e.g. if {playerDone == true...


    {
        Application.OpenURL("https://s.chkmkt.com/?e=195781&h=EDD1DF22921998D&l=en&q1=" + SystemInfo.deviceUniqueIdentifier);
    }
    }