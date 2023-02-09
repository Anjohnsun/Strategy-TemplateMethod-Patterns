using UnityEngine;

public class Enemy1 : AEnemyAttack
{
    public Enemy1(GameObject gameObject, Animator animator) : base(gameObject, animator)
    {
    }

    public override void Attack()
    {
        GameObject.SetActive(true);
        _animator.SetTrigger("attack");
    }

    public override void Stop()
    {
        GameObject.SetActive(false);
    }
}
