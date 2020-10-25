using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.Rendering.LWRP;
using UnityEngine.Rendering.Universal;

public class PlayerLightsController : MonoBehaviour
{
    private float lightRadius;
    private GameObject playerLight;
    private UnityEngine.Experimental.Rendering.Universal.Light2D lightParams;

    private void Start()
    {
        playerLight = GameObject.Find("Player Light");
        lightParams = playerLight.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
    }

    public void ManageLight(bool isBlind)
    {
        if (isBlind)
        {
            lightRadius = (float)2.5;
        }
        else { lightRadius = 5; }
        lightParams.pointLightOuterRadius = lightRadius;
    }
}
