using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private AttackPerformer _attackPerformer;
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private AttackButtonsHandler _attackButtonsHandler;

    private EnemyHandler _enemyHandler;

    [SerializeField] private EnemyInitializer _enIniter;

    void Start()
    {
        _attackPerformer = new AttackPerformer(_playerAnimator, _inputManager);
        _enemyHandler = new EnemyHandler(_enIniter.GetInitedEnemies());
        _attackButtonsHandler.Init(_attackPerformer, _enemyHandler);
    }
}
