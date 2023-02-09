using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPerformer
{
    private IAttackStrategy _actualAttack;
    private Animator _animator;

    public AttackPerformer(Animator animator, InputManager inputManager)
    {
        _animator = animator;
        inputManager.OnAttackInvoked.AddListener(Attack);
    }

    private void Attack()
    {
        if (_actualAttack != null)
            _actualAttack.Attack(_animator);
    }

    public void ChangeAttack(IAttackStrategy newAttack)
    {
        _actualAttack = newAttack;
    }
}
