using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    float gravity = -9.81f;

    Rigidbody rigid;

    bool isGrounded = false;

    [SerializeField]
    float sphereRadius;

    [SerializeField]
    LayerMask groundLayer;

    [SerializeField]
    Transform groundChecker;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundChecker.position, sphereRadius, groundLayer);
        if (isGrounded) {
            // allow jump
        } else {
            Vector3 axis = -Vector3.up;
            Vector3 gravityDirection = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z) * axis;
            Vector3 gravityForce = gravityDirection + new Vector3(0, gravity * Time.deltaTime, 0);
            rigid.velocity += gravityForce;
        }
    }

}
