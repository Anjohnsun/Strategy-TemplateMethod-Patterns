using UnityEngine;

public class Enemy3 : AEnemyAttack
{
    public Enemy3(GameObject gameObject, Animator animator, InputManager input) : base(gameObject, animator)
    {
        input.OnAttackInvoked.AddListener(MakeHit);
    }

    public override void Attack()
    {
        GameObject.SetActive(true);
    }
    public override void Stop()
    {
        GameObject.SetActive(false);
    }

    private void MakeHit()
    {
        _animator.SetTrigger("attack");
    }
}