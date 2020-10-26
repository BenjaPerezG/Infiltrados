using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour
{
    public bool isBlind;

    public void Blind()
    {
        isBlind = true;
    }
}
