using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text score;
    private void Awake()
    {
        score = GetComponent<Text>();
    }
    public void OnUpdate(int random)
    {
        score.text = "Score\n" + random.ToString();
    }
}
