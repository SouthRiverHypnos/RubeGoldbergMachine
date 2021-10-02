using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject[] Lightbulbs;
    
    // Start is called before the first frame update
    void Start()
    {
        /*boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;

        spriteRenderer = GetComponent<SpriteRenderer>();
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player"))
        {
            //Debug.Log("isOn");
            foreach (GameObject Lightbulb in Lightbulbs)
            {
                Lightbulb.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            }
        }
    }
}
