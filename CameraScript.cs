using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CameraSettings : MonoBehaviour
{
    public static float turnSpeed = 4.0f;
    public static float moveSpeed = 2.0f;
    public static float minTurnAngle = -90.0f;
    public static float maxTurnAngle = 90.0f;
    private float rotX;
    void Update()
    {
        MouseAiming();
    }
    void MouseAiming()
    {
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }
}