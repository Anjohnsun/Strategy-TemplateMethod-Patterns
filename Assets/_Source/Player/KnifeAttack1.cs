using UnityEngine;

public class KnifeAttack1 : IAttackStrategy
{
    public void Attack(Animator animator)
    {
        animator.SetTrigger("attack1");
    }
}
