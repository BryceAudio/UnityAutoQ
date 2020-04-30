using UnityEngine; 
using System.Collections;

public class OpenURL : MonoBehaviour 
{


    void Start() 

    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSfutmvWX2NzKnRHnjO4H8R4_Zat_tISDhEK5cZL3BkkNi-bZg/viewform?usp=sf_linkusp=pp_url&entry.315461126=" + SystemInfo.deviceUniqueIdentifier);
    }
    }

