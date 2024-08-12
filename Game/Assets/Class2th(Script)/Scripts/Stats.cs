using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    public int health;
    protected string name;

    public Data(int health, string name)
    {
        this.health = health;
        this.name = name;
    }

}
public class Stats : MonoBehaviour
{
    public GameObject bear;
    Data data = new Data(100,"Bear");
    public int attack = 30;
    void Start()
    {
        Debug.Log("attack 변수의 값 : " + attack);
    }

    void Update()
    {
        data.health--;
        Debug.Log(data.health);
        if(data.health < 0)
        {
            bear.SetActive(false);
        }
    }
    private void OnDisable()
    {
        Debug.Log("Die");
    }
}
