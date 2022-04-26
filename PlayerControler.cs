using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{   
    public float jump;
    Rigidbody2D player;
    public float health = 1;
    public GameObject expogen;
    float input;

    public ChareterDatabase chareterDB;
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;

    float lockPos = 0;

    public GameObject Gameover;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        if(!PlayerPrefs.HasKey("selectedOption"))
            selectedOption = 0;
        else
            Load();
        UpdateChareter(selectedOption);
    }
    
    private void Update() {
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);    
    }
    void FixedUpdate()
    {   
        if(Input.touchCount > 0)
            input = 1f;
        else
            input = 0f;
        player.velocity = new Vector2(player.velocity.x,input * jump );
    }
    public void OnTriggerEnter2D(Collider2D hitObject) {
        Instantiate(expogen,transform.position,Quaternion.identity);
        if(hitObject.tag == "Ground")
        {   
            kill();
        }
    }
    
    public void kill(){
        Destroy(gameObject);
        Gameover.SetActive(true);
    }

    private void UpdateChareter(int selectedOption)
    {
        Chareter chareter = chareterDB.GetChareter(selectedOption);
        artworkSprite.sprite = chareter.chareterSprite;
    }
    
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
