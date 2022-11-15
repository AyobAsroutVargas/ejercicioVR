using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject AlienDestroyer;
    public float minDistance = 3f;
    private bool isClose = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(AlienDestroyer.transform.position, transform.position);

        //if(distance < minDistance)
        //{
        //    transform.position = AlienDestroyer.transform.position + AlienDestroyer.transform.up * 2f;
        //}

        if (distance < minDistance && !isClose)
        {
            transform.position = AlienDestroyer.transform.position + AlienDestroyer.transform.up * 2f;
            isClose = true;
        }
        else if (distance > minDistance)
        {
            isClose = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = Vector3.zero;
        }
    }
}
