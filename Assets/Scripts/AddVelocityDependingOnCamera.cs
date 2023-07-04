using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocityDependingOnCamera : MonoBehaviour
{

    [SerializeField]
    KeyCode keyForward = KeyCode.W;

    [SerializeField]
    KeyCode keyBackward = KeyCode.S;

    [SerializeField]
    KeyCode keyLeft = KeyCode.A;

    [SerializeField]
    KeyCode keyRight = KeyCode.D;

    [SerializeField]
    float speedWS = 20f;

    [SerializeField]
    float speedAD = 60f;

    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Fixed Update is called 100 times per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyForward)) {
            rigid.velocity += new Vector3(Camera.main.transform.forward.x * speedWS * Time.deltaTime, 0, Camera.main.transform.forward.z * speedWS * Time.deltaTime);
        }
        if (Input.GetKey(keyBackward)) {
            rigid.velocity -= new Vector3(Camera.main.transform.forward.x * speedWS * Time.deltaTime, 0, Camera.main.transform.forward.z * speedWS * Time.deltaTime);
        }
        if (Input.GetKey(keyLeft)) {
            rigid.velocity -= Camera.main.transform.right * speedAD * Time.deltaTime;
        }
        if (Input.GetKey(keyRight)) {
            rigid.velocity += Camera.main.transform.right * speedAD * Time.deltaTime;
        }
    }
}
