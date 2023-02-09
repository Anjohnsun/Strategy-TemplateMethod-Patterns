using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AEnemyAttack
{
    protected int attack = Animator.StringToHash("Attack");
    
    public GameObject GameObject { get; set; }
    protected Animator _animator;

    public AEnemyAttack(GameObject gameObject, Animator animator)
    {
        GameObject = gameObject;
        _animator = animator;
    }

    public void DoAction()
    {
        Attack();
    }

    public abstract void Attack();
    public abstract void Stop();

}
