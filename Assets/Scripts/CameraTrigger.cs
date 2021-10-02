using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public bool Switch;
    // Start is called before the first frame update
    void Start()
    {
        Switch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cam1.enabled == true)
        {
            if (Switch)
            {
                cam1.enabled = false;
                cam2.enabled = true;
            }
        }
        else {
                 Switch = false;
    }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collider")) {
            Switch = true;
            Debug.Log(name + "triggered");
        }
    }


}
