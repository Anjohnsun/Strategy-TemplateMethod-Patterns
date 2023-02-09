using UnityEngine;

public class KnifeAttack2 : IAttackStrategy
{
    public void Attack(Animator animator)
    {
        animator.SetTrigger("attack2");
    }
}
