using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3force;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called exactly 100 times per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive)) {
            GetComponent<Rigidbody>().velocity += v3force;
        }
        if (Input.GetKey(keyNegative)) {
            GetComponent<Rigidbody>().velocity -= v3force;
        }
    }
}
