using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {
    public Transform lookAt;
    public Transform camTransform;

    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    private Camera cam;

    private float distance = 10.0f;
    private float currentX = 4.0f;
    private float currentY = 1.0f;
	// Use this for initialization
	private void Start ()
    {
        camTransform = transform;
        cam = Camera.main;
        
	}
    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");
    }
    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }


 
	
}
