using UnityEngine;

public class BowAttack1 : IAttackStrategy
{
    public void Attack(Animator animator)
    {
        animator.SetTrigger("attack3");
    }
}
