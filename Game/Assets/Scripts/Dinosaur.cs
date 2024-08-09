using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    private void Awake()
    {
        // Awake
        // ���� ������Ʈ�� �ν��Ͻ��� �Ŀ� ȣ��Ǵ� �Լ���,
        // �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ �� ������ ����, ����˴ϴ�.
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        // OnEnable
        // ���� ������Ʈ�� Ȱ��ȭ �Ǿ����� ȣ��Ǵ� �Լ��Դϴ�.
        Debug.Log("OnEnable");
    }
    void Start()
    {
        // start
        // ���� ������Ʈ�� ������ �Ŀ� ȣ��Ǵ� �Լ���,
        // �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� Ȱ��ȭ �� �����϶��� ȣ��˴ϴ�.
        Debug.Log("Start");
    }

    void Update()
    {
        // Update
        // �����Ӹ��� ȣ��Ǹ�, �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Update");
    }
    void FixedUpdate()
    {
        // FixedUpdate
        // Timestep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Fixed Update");
    }
    private void LateUpdate()
    {
        // LateUpdate
        // Update �Լ��� ������, ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("LateUpdate");
    }
    private void OnDisable()
    {
        // Ondisable
        // ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        // OnDestroy
        // ���� ������Ʈ�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDestroy");
    }
}
