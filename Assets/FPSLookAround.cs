﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLookAround : MonoBehaviour
{
    [SerializeField] Transform cam;
    [SerializeField] float sensitivity;
    float headRotation = 0f;
    [SerializeField] float headRotationLimit = 90f;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime * -1f;

        transform.Rotate(0f, x, 0f);

        headRotation += y;
        cam.localEulerAngles = new Vector3(headRotation, 0f, 0f);
        headRotation += y;
        headRotation = Mathf.Clamp(headRotation, -headRotationLimit, headRotationLimit);
        cam.localEulerAngles = new Vector3(headRotation, 0f, 0f);
    }
}
