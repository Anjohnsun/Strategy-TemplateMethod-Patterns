using UnityEngine;

public class Enemy2 : AEnemyAttack
{
    private GameObject _bullet;
    public Enemy2(GameObject gameObject, Animator animator, GameObject prefabToCreate) : base(gameObject, animator)
    {
        RegularAnimHandler.AnimationHappened.AddListener(AttackWithCreatedSmth);
        _bullet = prefabToCreate;
    }

    public override void Attack()
    {
        GameObject.SetActive(true);
        _animator.SetTrigger("attack");
    }

    private void AttackWithCreatedSmth()
    {
        Object.Instantiate(_bullet, new Vector2(0.38f, 0.25f), new Quaternion());
    }

    public override void Stop()
    {
        GameObject.SetActive(false);
        _animator.SetTrigger("stopAttack");
    }
}
