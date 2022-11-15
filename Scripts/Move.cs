using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float rotationY = Input.GetAxis("YRotation");

        Vector3 movement = transform.right * horizontal + transform.forward * vertical;
        movement = movement * speed * Time.deltaTime;

        Vector3 rotation = transform.up * rotationY * rotationSpeed * Time.deltaTime;

        transform.Translate(movement);
        transform.Rotate(rotation);
    }
}
