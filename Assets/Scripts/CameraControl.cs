using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    Vector3 cameraOffset;

    [SerializeField]
    float mouseSensivity = 500;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetMouseButton((1))) {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
            transform.RotateAround(player.position + cameraOffset, player.parent.up, mouseX);
            
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
            transform.RotateAround(player.position, transform.right, -mouseY);

            //transform.LookAt(player);
        }


    }

}
