using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChareterManager : MonoBehaviour
{
    public ChareterDatabase chareterDB;
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;
    void Start()
    {   
        if(!PlayerPrefs.HasKey("selectedOption"))
            selectedOption = 0;
        else
            Load();
        UpdateChareter(selectedOption);
    }
    public void NextOption()
    {
        selectedOption++;
        if(selectedOption >= chareterDB.CharetereCount)
            selectedOption = 0;
        UpdateChareter(selectedOption);
        Save();
    }

    public void BackOpction()
    {
        selectedOption--;
        if(selectedOption < 0)
            selectedOption = chareterDB.CharetereCount - 1;
        UpdateChareter(selectedOption);
        Save();
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

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption",selectedOption);
    }
}
