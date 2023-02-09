using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButtonsHandler : MonoBehaviour
{
    private KnifeAttack1 _attack1 = new KnifeAttack1();
    private KnifeAttack2 _attack2 = new KnifeAttack2();
    private BowAttack1 _attack3 = new BowAttack1();

    private AttackPerformer _attackPerformer;
    private EnemyHandler _enemyHandler;

    public void Init(AttackPerformer attackPerformer, EnemyHandler enemyHandler)
    {
        _attackPerformer = attackPerformer;
        _enemyHandler = enemyHandler;
    }

    public void OnAttack1Chosen()
    {
        _attackPerformer.ChangeAttack(_attack1);
        _enemyHandler.ChangeActualEnemy(1);
    }
    public void OnAttack2Chosen()
    {
        _attackPerformer.ChangeAttack(_attack2);
        _enemyHandler.ChangeActualEnemy(2);
    }
    public void OnAttack3Chosen()
    {
        _attackPerformer.ChangeAttack(_attack3);
        _enemyHandler.ChangeActualEnemy(3);
    }
}
