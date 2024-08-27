using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text score;
    [SerializeField] DataManager dataManager;
    void Update()
    {
        score.text = dataManager.score.ToString();
    }
}
