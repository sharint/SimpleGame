using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public bool isLeave;

    void OnBecameInvisible()
    {
        isLeave = true;
    }
}
