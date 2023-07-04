using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{

    [SerializeField]
    Transform sourceObject;

    [SerializeField]
    Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = cameraOffset + sourceObject.position;
    }

}
