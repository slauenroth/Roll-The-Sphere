using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceOnCollision : MonoBehaviour
{

    [SerializeField]
    Vector3 v3force;

    [SerializeField]
    float timeBetween = 1f;

    float timePassed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        timePassed += Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (timePassed > timeBetween) {
            timePassed = 0f;
            collision.collider.GetComponent<Rigidbody>().velocity += v3force;
        }
        
    }

}
