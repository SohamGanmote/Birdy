using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ChareterDatabase : ScriptableObject
{
    public Chareter[] chareter;
    public int CharetereCount
    {
        get 
        {
            return chareter.Length;
        }

    }
    public Chareter GetChareter(int index)
    {
        return chareter[index];
    }
}
