using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScourCounter : MonoBehaviour
{   
    public GameObject player;
    public Text ScoreDisplay;
    public Text MainScour;
    int count = 0;
    public int scour = 0;
    int temp = 0;
    AudioSource source1;
    public Text HIGHSCOUR;
    void Start() {
        source1 = GetComponent<AudioSource>();
        ScoreDisplay.text = scour.ToString();
        HIGHSCOUR.text = PlayerPrefs.GetInt("HighScour",0).ToString();
    }
    public void OnTriggerEnter2D(Collider2D hitObject) {
        if(hitObject.tag == "Enemy")
        {   
            if(temp == 10)
            {
                source1.Play();
                temp = 0;
            }
            if(count % 2 == 0){
                if(player != null){
                    scour++;
                    temp++;
                }
            }
            count++;
        }
        ScoreDisplay.text = scour.ToString();
        if(scour > PlayerPrefs.GetInt("HighScour",0))
        {
            PlayerPrefs.SetInt("HighScour",scour);
            HIGHSCOUR.text = scour.ToString();
        }
        MainScour.text = ScoreDisplay.text;
    }

    public void Reset() {
            PlayerPrefs.DeleteKey("HighScour");
    }
}
