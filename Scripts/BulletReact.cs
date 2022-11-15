using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletReact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMessage()
    {
        transform.position = transform.position + Vector3.up * 3f;
    }
}
