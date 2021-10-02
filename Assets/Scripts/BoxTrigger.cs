using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    public GameObject[] Pendulums;
    public GameObject[] Axes;
    public bool Triggered;
    // Start is called before the first frame update
    void Start()
    {
        Triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject Axis in Axes)
        {
            Rigidbody2D rb2dAxis = Axis.GetComponent<Rigidbody2D>();
            if (Triggered)
            {
                rb2dAxis.bodyType = RigidbodyType2D.Dynamic;
            }
            else
            {
                rb2dAxis.bodyType = RigidbodyType2D.Kinematic;
            }
        }
     
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Square"))
        {
            Debug.Log("isOn");
            foreach (GameObject Pendulum in Pendulums)
            {
                Rigidbody2D rb2dPendulum = Pendulum.GetComponent<Rigidbody2D>();
                rb2dPendulum.gravityScale = 1;
            }
            Triggered = true;
        }
    }
}
