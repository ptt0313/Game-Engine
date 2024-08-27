using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] public int score;
    public void IncreaseScore()
    {
        score += Random.Range(5, 10);
        PlayerPrefs.SetInt("Score", score);
    }
    void Awake()
    {
        Load();
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");
    }
    public void Save()
    {
        PlayerPrefs.Save();
    }
    public void ResetScore()
    {
         PlayerPrefs.DeleteAll();
        Load();
    }
}
