using UnityEngine;

public class _DamgeSender : MonoBehaviour
{
    protected _EnemyCotroller _enemyController;

    private void Awake()
    {
        this._enemyController = GetComponent<_EnemyCotroller>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _DamgeReceiver damgeReceiver = collision.GetComponent<_DamgeReceiver>();
        if (damgeReceiver == null) return;

        damgeReceiver.Receive(1);

        this._enemyController._despawner.Destroy();
    }
}
