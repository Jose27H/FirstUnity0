using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public Camera cam;
    private float xRotation = 0f;
    private float xSensitivity = 30f;
    private float ySensitivity = 30f;
  
    public void processLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //some wird shi
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);  
        //rotate player
        transform.Rotate(Vector3.up* (mouseX * Time.deltaTime)* xSensitivity);
    }
}
