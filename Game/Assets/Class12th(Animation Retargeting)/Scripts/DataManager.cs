using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Unity.UI;

public class DataManager : MonoBehaviour
{
    [SerializeField] public int score;
    [SerializeField] Score scoreUI; 
    public void IncreaseScore()
    {
        int random = Random.Range(5, 11);
        score += random;

        scoreUI.OnUpdate(score);
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
