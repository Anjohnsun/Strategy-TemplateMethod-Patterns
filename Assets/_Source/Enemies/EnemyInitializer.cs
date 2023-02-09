using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInitializer : MonoBehaviour
{
    private Enemy1 _en1;
    private Enemy2 _en2;
    private Enemy3 _en3;

    [SerializeField] private GameObject _enB1;
    [SerializeField] private GameObject _enB2;
    [SerializeField] private GameObject _enB3;

    [SerializeField] private Animator _animator1;
    [SerializeField] private Animator _animator2;
    [SerializeField] private Animator _animator3;

    [SerializeField] private GameObject _prefabForEnemy2;
    [SerializeField] private InputManager _inputManager;

    List<AEnemyAttack> enemies = new List<AEnemyAttack>();

    private void Start()
    {
        _en1 = new Enemy1(_enB1, _animator1);
        _en2 = new Enemy2(_enB2, _animator2, _prefabForEnemy2);
        _en3 = new Enemy3(_enB3, _animator3, _inputManager);

        enemies.Add(_en1);
        enemies.Add(_en2);
        enemies.Add(_en3);
    }

    public List<AEnemyAttack> GetInitedEnemies()
    {
        return enemies;
    }
}
