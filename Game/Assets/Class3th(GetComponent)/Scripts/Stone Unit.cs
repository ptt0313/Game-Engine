using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Move))]
public class StoneUnit : MonoBehaviour
{
    [SerializeField] private Move move;
    // [SerializeField] : private 나 protected 상태의 변수를 인스펙터 창에 노출시켜줌.
    private void Awake()
    {
        move = GetComponent<Move>();
        //GetComponent<>() : 컴포넌트를 가져옴
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            move.OnMove(new Vector3(0, 0, 1));
            //move.OnMove(Vector3.forward);
            //Debug.Log("Forward");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            move.OnMove(new Vector3(-1, 0, 0));
            //move.OnMove(Vector3.left);
            //Debug.Log("Left");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            move.OnMove(new Vector3(1, 0, 0));
            //move.OnMove(Vector3.right);
            //Debug.Log("Right");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            move.OnMove(new Vector3(0, 0, -1));
            //move.OnMove(Vector3.back);
            //Debug.Log("Back");
        }

    }
}
