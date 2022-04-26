using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] Enemys;

    private float timeBwtSpawns;
    public float startTimeBetSpawns;
    int num = 0;
    public GameObject player1;
    PlayerControler player;
    void Start()
    {
        player =  GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControler>();
    }
    void Update()
    {   
         if(player1 != null)
         {
            if(timeBwtSpawns <= 0)
            {   

                Transform randomSpwanPoint = SpawnPoints[num]; 
                GameObject randomEnemy = Enemys[Random.Range(0,Enemys.Length)];
             
                Instantiate(randomEnemy,randomSpwanPoint.position,Quaternion.identity);
                num = (num + 1) % 4;
                timeBwtSpawns = startTimeBetSpawns;
            }
            else
            {
                timeBwtSpawns = timeBwtSpawns - Time.deltaTime;
            }
        }   
    }
}
