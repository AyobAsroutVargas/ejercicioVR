using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public GameObject[] objetives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter()
    {
        Debug.Log("Mirando " + this.name);
        foreach(var obj in objetives)
        {
            obj?.SendMessage("OnMessage", null, SendMessageOptions.DontRequireReceiver);
        }
    }

    //public void OnPointerExit()
    //{
    //    Debug.Log("Mirando " + this.name);
    //}
}
