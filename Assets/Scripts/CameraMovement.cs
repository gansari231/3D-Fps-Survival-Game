using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Camera _mainCamera;

    void Start()
    {
        _mainCamera = Camera.main;
    }

    void Update()
    {
        MouseMovement();
    }

    void MouseMovement()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 currentRotation = transform.localEulerAngles;
        currentRotation.y += mouseX;
        transform.localRotation = Quaternion.AngleAxis(currentRotation.y, Vector3.up);

        Vector3 currentCameraRotation = _mainCamera.gameObject.transform.localEulerAngles;
        currentCameraRotation.x -= mouseY;
        _mainCamera.gameObject.transform.localRotation = Quaternion.AngleAxis(currentCameraRotation.x, Vector3.right);

    }
}
