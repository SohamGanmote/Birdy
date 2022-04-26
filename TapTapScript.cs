using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapTapScript : MonoBehaviour
{   
    float speed = 5;
    void Update()
    {
         transform.Translate(Vector2.left * speed * Time.deltaTime);	
    }
    void OnTriggerEnter2D(Collider2D hitObject)
    {   
        if(hitObject.tag == "Distroy")
            Destroy(gameObject);
    }
}
