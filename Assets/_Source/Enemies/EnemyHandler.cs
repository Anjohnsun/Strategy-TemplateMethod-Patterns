using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler
{
    private AEnemyAttack _actualEnemy;
    private List<AEnemyAttack> _enemies;

    public EnemyHandler(List<AEnemyAttack> enemies)
    {
        _enemies = enemies;
    }

    public void ChangeActualEnemy(int enemyNum)
    {
        if (enemyNum <= _enemies.Count && _enemies[enemyNum - 1] != _actualEnemy)
        {
            if (_actualEnemy != null) _actualEnemy.Stop();
            _actualEnemy = _enemies[enemyNum - 1];
            _actualEnemy.Attack();
        }
    }
}
