using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObjectOnCollision : MonoBehaviour
{

    [SerializeField]
    Transform newPosition;


    void OnCollisionEnter(Collision collision)
    {
        collision.collider.GetComponent<Transform>().position = newPosition.position;
    }

}
