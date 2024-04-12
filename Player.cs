using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // You can choose the speed in Unity by transferring the script to the object.

    public float WalkSpeed; 
    public float rotationSpeed;
    public float minYRotation;
    public float maxYRotation;

    private float currentYRotation = 0f;

    void Update()
    {
        // Mouse control
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        currentYRotation += mouseY;
        currentYRotation = Mathf.Clamp(currentYRotation, minYRotation, maxYRotation);

        transform.rotation = Quaternion.Euler(-currentYRotation, transform.eulerAngles.y + mouseX, 0);

        // Walk W A S D
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * WalkSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * WalkSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * WalkSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * WalkSpeed);
        }
    }
}