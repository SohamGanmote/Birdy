using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    public float speed;
    PlayerControler player;
    void Start()
    {
        player =  GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControler>();
    }

    void Update(){   
        transform.Translate(Vector2.left * speed * Time.deltaTime);		
    }
    
    void OnTriggerEnter2D(Collider2D hitObject)
    {   
        if(hitObject.tag == "Player")
        {   
            player.kill();
        }
        if(hitObject.tag == "Distroy")
            Destroy(gameObject);
    }
}
