using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayTime : MonoBehaviour
{

    public PlayTime playTimer;

    void OnCollisionEnter(Collision collision)
    {
        playTimer.isStopped = true;
    }

}
