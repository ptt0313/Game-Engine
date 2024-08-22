using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swarm : MonoBehaviour
{
    [SerializeField] AudioClip attackSound;
    [SerializeField] Animator animator;
    [SerializeField] int deathCount;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public void Die()
    {
        animator.SetTrigger("Die");
    }
    public void OnDamage(int count)
    {
        SoundManager.Instance.Sound(attackSound);
        deathCount += count;
        if(deathCount >= 5)
        {
            Die();
        }
    }
    public void Release()
    {
        Destroy(gameObject);
    }
}
