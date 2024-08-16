using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    [SerializeField] GameObject selectIcon;
    public void OnEnter()
    {
        selectIcon.SetActive(true);
    }
    public void OnExit()
    {
        selectIcon.SetActive(false);
    }
    
}
